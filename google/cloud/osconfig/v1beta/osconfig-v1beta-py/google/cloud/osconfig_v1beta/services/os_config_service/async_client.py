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
from typing import Dict, Sequence, Tuple, Type, Union
import pkg_resources

import google.api_core.client_options as ClientOptions # type: ignore
from google.api_core import exceptions                 # type: ignore
from google.api_core import gapic_v1                   # type: ignore
from google.api_core import retry as retries           # type: ignore
from google.auth import credentials                    # type: ignore
from google.oauth2 import service_account              # type: ignore

from google.cloud.osconfig_v1beta.services.os_config_service import pagers
from google.cloud.osconfig_v1beta.types import guest_policies
from google.cloud.osconfig_v1beta.types import patch_deployments
from google.cloud.osconfig_v1beta.types import patch_jobs
from google.protobuf import duration_pb2 as duration  # type: ignore
from google.protobuf import field_mask_pb2 as field_mask  # type: ignore
from google.protobuf import timestamp_pb2 as timestamp  # type: ignore
from .transports.base import OsConfigServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import OsConfigServiceGrpcAsyncIOTransport
from .client import OsConfigServiceClient


class OsConfigServiceAsyncClient:
    """OS Config API
    The OS Config service is a server-side component that you can
    use to manage package installations and patch jobs for virtual
    machine instances.
    """

    _client: OsConfigServiceClient

    DEFAULT_ENDPOINT = OsConfigServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = OsConfigServiceClient.DEFAULT_MTLS_ENDPOINT

    guest_policy_path = staticmethod(OsConfigServiceClient.guest_policy_path)
    parse_guest_policy_path = staticmethod(OsConfigServiceClient.parse_guest_policy_path)
    common_billing_account_path = staticmethod(OsConfigServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(OsConfigServiceClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(OsConfigServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(OsConfigServiceClient.parse_common_folder_path)
    common_organization_path = staticmethod(OsConfigServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(OsConfigServiceClient.parse_common_organization_path)
    common_project_path = staticmethod(OsConfigServiceClient.common_project_path)
    parse_common_project_path = staticmethod(OsConfigServiceClient.parse_common_project_path)
    common_location_path = staticmethod(OsConfigServiceClient.common_location_path)
    parse_common_location_path = staticmethod(OsConfigServiceClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            OsConfigServiceAsyncClient: The constructed client.
        """
        return OsConfigServiceClient.from_service_account_info.__func__(OsConfigServiceAsyncClient, info, *args, **kwargs)  # type: ignore

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
            OsConfigServiceAsyncClient: The constructed client.
        """
        return OsConfigServiceClient.from_service_account_file.__func__(OsConfigServiceAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> OsConfigServiceTransport:
        """Return the transport used by the client instance.

        Returns:
            OsConfigServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(OsConfigServiceClient).get_transport_class, type(OsConfigServiceClient))

    def __init__(self, *,
            credentials: credentials.Credentials = None,
            transport: Union[str, OsConfigServiceTransport] = 'grpc_asyncio',
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiate the os config service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.OsConfigServiceTransport]): The
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
        self._client = OsConfigServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def execute_patch_job(self,
            request: patch_jobs.ExecutePatchJobRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> patch_jobs.PatchJob:
        r"""Patch VM instances by creating and running a patch
        job.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.ExecutePatchJobRequest`):
                The request object.
                A request message to initiate
                patching across Google Compute Engine instances.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig_v1beta.types.PatchJob:
                A high level representation of a patch job that is either in progress
                   or has completed.

                   Instances details are not included in the job. To
                   paginate through instance details, use
                   ListPatchJobInstanceDetails.

                   For more information about patch jobs, see [Creating
                   patch
                   jobs](/compute/docs/os-patch-management/create-patch-job).

        """
        # Create or coerce a protobuf request object.
        request = patch_jobs.ExecutePatchJobRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.execute_patch_job,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('parent', request.parent),
            )),
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

    async def get_patch_job(self,
            request: patch_jobs.GetPatchJobRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> patch_jobs.PatchJob:
        r"""Get the patch job. This can be used to track the
        progress of an ongoing patch job or review the details
        of completed jobs.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.GetPatchJobRequest`):
                The request object.
                Request to get an active or
                completed patch job.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig_v1beta.types.PatchJob:
                A high level representation of a patch job that is either in progress
                   or has completed.

                   Instances details are not included in the job. To
                   paginate through instance details, use
                   ListPatchJobInstanceDetails.

                   For more information about patch jobs, see [Creating
                   patch
                   jobs](/compute/docs/os-patch-management/create-patch-job).

        """
        # Create or coerce a protobuf request object.
        request = patch_jobs.GetPatchJobRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_patch_job,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', request.name),
            )),
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

    async def cancel_patch_job(self,
            request: patch_jobs.CancelPatchJobRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> patch_jobs.PatchJob:
        r"""Cancel a patch job. The patch job must be active.
        Canceled patch jobs cannot be restarted.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.CancelPatchJobRequest`):
                The request object.
                Message for canceling a patch job.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig_v1beta.types.PatchJob:
                A high level representation of a patch job that is either in progress
                   or has completed.

                   Instances details are not included in the job. To
                   paginate through instance details, use
                   ListPatchJobInstanceDetails.

                   For more information about patch jobs, see [Creating
                   patch
                   jobs](/compute/docs/os-patch-management/create-patch-job).

        """
        # Create or coerce a protobuf request object.
        request = patch_jobs.CancelPatchJobRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.cancel_patch_job,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', request.name),
            )),
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

    async def list_patch_jobs(self,
            request: patch_jobs.ListPatchJobsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListPatchJobsAsyncPager:
        r"""Get a list of patch jobs.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.ListPatchJobsRequest`):
                The request object.
                A request message for listing patch
                jobs.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig_v1beta.services.os_config_service.pagers.ListPatchJobsAsyncPager:
                A response message for listing patch
                jobs.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = patch_jobs.ListPatchJobsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_patch_jobs,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('parent', request.parent),
            )),
        )

        # Send the request.
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__aiter__` convenience method.
        response = pagers.ListPatchJobsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def list_patch_job_instance_details(self,
            request: patch_jobs.ListPatchJobInstanceDetailsRequest = None,
            *,
            parent: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListPatchJobInstanceDetailsAsyncPager:
        r"""Get a list of instance details for a given patch job.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.ListPatchJobInstanceDetailsRequest`):
                The request object.
                Request to list details for all
                instances that are part of a patch job.
            parent (:class:`str`):
                Required. The parent for the instances are in the form
                of ``projects/*/patchJobs/*``.

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig_v1beta.services.os_config_service.pagers.ListPatchJobInstanceDetailsAsyncPager:
                A response message for listing the
                instances details for a patch job.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = patch_jobs.ListPatchJobInstanceDetailsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_patch_job_instance_details,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('parent', request.parent),
            )),
        )

        # Send the request.
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__aiter__` convenience method.
        response = pagers.ListPatchJobInstanceDetailsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def create_patch_deployment(self,
            request: patch_deployments.CreatePatchDeploymentRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> patch_deployments.PatchDeployment:
        r"""Create an OS Config patch deployment.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.CreatePatchDeploymentRequest`):
                The request object.
                A request message for creating a
                patch deployment.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig_v1beta.types.PatchDeployment:
                Patch deployments are configurations that individual patch jobs use to
                   complete a patch. These configurations include
                   instance filter, package repository settings, and a
                   schedule. For more information about creating and
                   managing patch deployments, see [Scheduling patch
                   jobs](/compute/docs/os-patch-management/schedule-patch-jobs).

        """
        # Create or coerce a protobuf request object.
        request = patch_deployments.CreatePatchDeploymentRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_patch_deployment,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('parent', request.parent),
            )),
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

    async def get_patch_deployment(self,
            request: patch_deployments.GetPatchDeploymentRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> patch_deployments.PatchDeployment:
        r"""Get an OS Config patch deployment.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.GetPatchDeploymentRequest`):
                The request object.
                A request message for retrieving a
                patch deployment.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig_v1beta.types.PatchDeployment:
                Patch deployments are configurations that individual patch jobs use to
                   complete a patch. These configurations include
                   instance filter, package repository settings, and a
                   schedule. For more information about creating and
                   managing patch deployments, see [Scheduling patch
                   jobs](/compute/docs/os-patch-management/schedule-patch-jobs).

        """
        # Create or coerce a protobuf request object.
        request = patch_deployments.GetPatchDeploymentRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_patch_deployment,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', request.name),
            )),
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

    async def list_patch_deployments(self,
            request: patch_deployments.ListPatchDeploymentsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListPatchDeploymentsAsyncPager:
        r"""Get a page of OS Config patch deployments.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.ListPatchDeploymentsRequest`):
                The request object.
                A request message for listing patch
                deployments.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig_v1beta.services.os_config_service.pagers.ListPatchDeploymentsAsyncPager:
                A response message for listing patch
                deployments.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = patch_deployments.ListPatchDeploymentsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_patch_deployments,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('parent', request.parent),
            )),
        )

        # Send the request.
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__aiter__` convenience method.
        response = pagers.ListPatchDeploymentsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def delete_patch_deployment(self,
            request: patch_deployments.DeletePatchDeploymentRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Delete an OS Config patch deployment.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.DeletePatchDeploymentRequest`):
                The request object.
                A request message for deleting a
                patch deployment.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.
        request = patch_deployments.DeletePatchDeploymentRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_patch_deployment,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', request.name),
            )),
        )

        # Send the request.
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    async def create_guest_policy(self,
            request: guest_policies.CreateGuestPolicyRequest = None,
            *,
            parent: str = None,
            guest_policy: guest_policies.GuestPolicy = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> guest_policies.GuestPolicy:
        r"""Create an OS Config guest policy.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.CreateGuestPolicyRequest`):
                The request object.
                A request message for creating a
                guest policy.
            parent (:class:`str`):
                Required. The resource name of the parent using one of
                the following forms: ``projects/{project_number}``.

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            guest_policy (:class:`google.cloud.osconfig_v1beta.types.GuestPolicy`):
                Required. The GuestPolicy to create.
                This corresponds to the ``guest_policy`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig_v1beta.types.GuestPolicy:
                An OS Config resource representing a
                guest configuration policy. These
                policies represent the desired state for
                VM instance guest environments including
                packages to install or remove, package
                repository configurations, and software
                to install.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent, guest_policy])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = guest_policies.CreateGuestPolicyRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent
        if guest_policy is not None:
            request.guest_policy = guest_policy

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_guest_policy,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('parent', request.parent),
            )),
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

    async def get_guest_policy(self,
            request: guest_policies.GetGuestPolicyRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> guest_policies.GuestPolicy:
        r"""Get an OS Config guest policy.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.GetGuestPolicyRequest`):
                The request object.
                A request message for retrieving a
                guest policy.
            name (:class:`str`):
                Required. The resource name of the guest policy using
                one of the following forms:
                ``projects/{project_number}/guestPolicies/{guest_policy_id}``.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig_v1beta.types.GuestPolicy:
                An OS Config resource representing a
                guest configuration policy. These
                policies represent the desired state for
                VM instance guest environments including
                packages to install or remove, package
                repository configurations, and software
                to install.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = guest_policies.GetGuestPolicyRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_guest_policy,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', request.name),
            )),
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

    async def list_guest_policies(self,
            request: guest_policies.ListGuestPoliciesRequest = None,
            *,
            parent: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListGuestPoliciesAsyncPager:
        r"""Get a page of OS Config guest policies.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.ListGuestPoliciesRequest`):
                The request object.
                A request message for listing guest
                policies.
            parent (:class:`str`):
                Required. The resource name of the parent using one of
                the following forms: ``projects/{project_number}``.

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig_v1beta.services.os_config_service.pagers.ListGuestPoliciesAsyncPager:
                A response message for listing guest
                policies.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = guest_policies.ListGuestPoliciesRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_guest_policies,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('parent', request.parent),
            )),
        )

        # Send the request.
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__aiter__` convenience method.
        response = pagers.ListGuestPoliciesAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def update_guest_policy(self,
            request: guest_policies.UpdateGuestPolicyRequest = None,
            *,
            guest_policy: guest_policies.GuestPolicy = None,
            update_mask: field_mask.FieldMask = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> guest_policies.GuestPolicy:
        r"""Update an OS Config guest policy.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.UpdateGuestPolicyRequest`):
                The request object.
                A request message for updating a
                guest policy.
            guest_policy (:class:`google.cloud.osconfig_v1beta.types.GuestPolicy`):
                Required. The updated GuestPolicy.
                This corresponds to the ``guest_policy`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            update_mask (:class:`google.protobuf.field_mask_pb2.FieldMask`):
                Field mask that controls which fields
                of the guest policy should be updated.

                This corresponds to the ``update_mask`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig_v1beta.types.GuestPolicy:
                An OS Config resource representing a
                guest configuration policy. These
                policies represent the desired state for
                VM instance guest environments including
                packages to install or remove, package
                repository configurations, and software
                to install.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([guest_policy, update_mask])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = guest_policies.UpdateGuestPolicyRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if guest_policy is not None:
            request.guest_policy = guest_policy
        if update_mask is not None:
            request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_guest_policy,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('guest_policy.name', request.guest_policy.name),
            )),
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

    async def delete_guest_policy(self,
            request: guest_policies.DeleteGuestPolicyRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Delete an OS Config guest policy.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.DeleteGuestPolicyRequest`):
                The request object.
                A request message for deleting a
                guest policy.
            name (:class:`str`):
                Required. The resource name of the guest policy using
                one of the following forms:
                ``projects/{project_number}/guestPolicies/{guest_policy_id}``.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = guest_policies.DeleteGuestPolicyRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_guest_policy,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', request.name),
            )),
        )

        # Send the request.
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    async def lookup_effective_guest_policy(self,
            request: guest_policies.LookupEffectiveGuestPolicyRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> guest_policies.EffectiveGuestPolicy:
        r"""Lookup the effective guest policy that applies to a
        VM instance. This lookup merges all policies that are
        assigned to the instance ancestry.

        Args:
            request (:class:`google.cloud.osconfig_v1beta.types.LookupEffectiveGuestPolicyRequest`):
                The request object.
                A request message for getting the
                effective guest policy assigned to the instance.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig_v1beta.types.EffectiveGuestPolicy:
                The effective guest policy that
                applies to a VM instance.

        """
        # Create or coerce a protobuf request object.
        request = guest_policies.LookupEffectiveGuestPolicyRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.lookup_effective_guest_policy,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('instance', request.instance),
            )),
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
            'google-cloud-osconfig',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    'OsConfigServiceAsyncClient',
)
