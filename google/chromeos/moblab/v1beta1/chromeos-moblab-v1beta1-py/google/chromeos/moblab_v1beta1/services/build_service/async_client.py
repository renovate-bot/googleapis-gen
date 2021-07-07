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
from google.api_core import exceptions as core_exceptions  # type: ignore
from google.api_core import gapic_v1                   # type: ignore
from google.api_core import retry as retries           # type: ignore
from google.auth import credentials as ga_credentials   # type: ignore
from google.oauth2 import service_account              # type: ignore

from google.api_core import operation  # type: ignore
from google.api_core import operation_async  # type: ignore
from google.chromeos.moblab_v1beta1.services.build_service import pagers
from google.chromeos.moblab_v1beta1.types import build_service
from google.chromeos.moblab_v1beta1.types import resources
from .transports.base import BuildServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import BuildServiceGrpcAsyncIOTransport
from .client import BuildServiceClient


class BuildServiceAsyncClient:
    """Manages Chrome OS build services."""

    _client: BuildServiceClient

    DEFAULT_ENDPOINT = BuildServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = BuildServiceClient.DEFAULT_MTLS_ENDPOINT

    build_path = staticmethod(BuildServiceClient.build_path)
    parse_build_path = staticmethod(BuildServiceClient.parse_build_path)
    build_artifact_path = staticmethod(BuildServiceClient.build_artifact_path)
    parse_build_artifact_path = staticmethod(BuildServiceClient.parse_build_artifact_path)
    build_target_path = staticmethod(BuildServiceClient.build_target_path)
    parse_build_target_path = staticmethod(BuildServiceClient.parse_build_target_path)
    milestone_path = staticmethod(BuildServiceClient.milestone_path)
    parse_milestone_path = staticmethod(BuildServiceClient.parse_milestone_path)
    model_path = staticmethod(BuildServiceClient.model_path)
    parse_model_path = staticmethod(BuildServiceClient.parse_model_path)
    common_billing_account_path = staticmethod(BuildServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(BuildServiceClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(BuildServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(BuildServiceClient.parse_common_folder_path)
    common_organization_path = staticmethod(BuildServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(BuildServiceClient.parse_common_organization_path)
    common_project_path = staticmethod(BuildServiceClient.common_project_path)
    parse_common_project_path = staticmethod(BuildServiceClient.parse_common_project_path)
    common_location_path = staticmethod(BuildServiceClient.common_location_path)
    parse_common_location_path = staticmethod(BuildServiceClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            BuildServiceAsyncClient: The constructed client.
        """
        return BuildServiceClient.from_service_account_info.__func__(BuildServiceAsyncClient, info, *args, **kwargs)  # type: ignore

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
            BuildServiceAsyncClient: The constructed client.
        """
        return BuildServiceClient.from_service_account_file.__func__(BuildServiceAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> BuildServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            BuildServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(BuildServiceClient).get_transport_class, type(BuildServiceClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, BuildServiceTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the build service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.BuildServiceTransport]): The
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
        self._client = BuildServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def list_build_targets(self,
            request: build_service.ListBuildTargetsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListBuildTargetsAsyncPager:
        r"""Lists all build targets that a user has access to.

        Args:
            request (:class:`google.chromeos.moblab_v1beta1.types.ListBuildTargetsRequest`):
                The request object. Request message for listing build
                targets.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.chromeos.moblab_v1beta1.services.build_service.pagers.ListBuildTargetsAsyncPager:
                Response message for listing build
                targets.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = build_service.ListBuildTargetsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_build_targets,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
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
        response = pagers.ListBuildTargetsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def list_builds(self,
            request: build_service.ListBuildsRequest = None,
            *,
            parent: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListBuildsAsyncPager:
        r"""Lists all builds for the given build target and model
        in descending order for the milestones and build
        versions.

        Args:
            request (:class:`google.chromeos.moblab_v1beta1.types.ListBuildsRequest`):
                The request object. Request message for listing builds.
            parent (:class:`str`):
                Required. The full resource name of
                the model. The model id is the same as
                the build target id for non-unified
                builds. For example,
                'buildTargets/octopus/models/bobba'.

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.chromeos.moblab_v1beta1.services.build_service.pagers.ListBuildsAsyncPager:
                Response message for listing builds.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = build_service.ListBuildsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_builds,
            default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.ServiceUnavailable,
                ),
                deadline=60.0,
            ),
            default_timeout=60.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
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
        response = pagers.ListBuildsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def check_build_stage_status(self,
            request: build_service.CheckBuildStageStatusRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> build_service.CheckBuildStageStatusResponse:
        r"""Checks the stage status for a given build artifact in
        a partner Google Cloud Storage bucket.

        Args:
            request (:class:`google.chromeos.moblab_v1beta1.types.CheckBuildStageStatusRequest`):
                The request object. Request message for checking if the
                build artifact is staged.
            name (:class:`str`):
                Required. The full resource name of
                the build artifact. For example,
                'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-
                moblab-peng-staging'.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.chromeos.moblab_v1beta1.types.CheckBuildStageStatusResponse:
                Response message for checking the
                stage status of a build artifact.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = build_service.CheckBuildStageStatusRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.check_build_stage_status,
            default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.ServiceUnavailable,
                ),
                deadline=60.0,
            ),
            default_timeout=60.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
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

    async def stage_build(self,
            request: build_service.StageBuildRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Stages a given build artifact from a internal Google Cloud
        Storage bucket to a partner Google Cloud Storage bucket. If any
        of objects has already been copied, it will overwrite the
        previous objects. Operation <response:
        [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
        metadata:
        [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]>

        Args:
            request (:class:`google.chromeos.moblab_v1beta1.types.StageBuildRequest`):
                The request object. Request message for staging a build
                artifact.
            name (:class:`str`):
                Required. The full resource name of
                the build artifact. For example,
                'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-
                moblab-peng-staging'.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.chromeos.moblab_v1beta1.types.StageBuildResponse`
                Response message for staging a build artifact.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = build_service.StageBuildRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.stage_build,
            default_timeout=60.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation_async.from_gapic(
            response,
            self._client._transport.operations_client,
            build_service.StageBuildResponse,
            metadata_type=build_service.StageBuildMetadata,
        )

        # Done; return the response.
        return response





try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            "google-chromeos-moblab",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "BuildServiceAsyncClient",
)
