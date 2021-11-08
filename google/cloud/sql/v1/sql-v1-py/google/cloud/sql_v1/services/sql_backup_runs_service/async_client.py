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

from google.api_core.client_options import ClientOptions
from google.api_core import exceptions as core_exceptions
from google.api_core import gapic_v1
from google.api_core import retry as retries
from google.auth import credentials as ga_credentials   # type: ignore
from google.oauth2 import service_account              # type: ignore

try:
    OptionalRetry = Union[retries.Retry, gapic_v1.method._MethodDefault]
except AttributeError:  # pragma: NO COVER
    OptionalRetry = Union[retries.Retry, object]  # type: ignore

from google.cloud.sql_v1.services.sql_backup_runs_service import pagers
from google.cloud.sql_v1.types import cloud_sql_backup_runs
from google.cloud.sql_v1.types import cloud_sql_resources
from google.protobuf import timestamp_pb2  # type: ignore
from .transports.base import SqlBackupRunsServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import SqlBackupRunsServiceGrpcAsyncIOTransport
from .client import SqlBackupRunsServiceClient


class SqlBackupRunsServiceAsyncClient:
    """Service for managing database backups."""

    _client: SqlBackupRunsServiceClient

    DEFAULT_ENDPOINT = SqlBackupRunsServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = SqlBackupRunsServiceClient.DEFAULT_MTLS_ENDPOINT

    common_billing_account_path = staticmethod(SqlBackupRunsServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(SqlBackupRunsServiceClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(SqlBackupRunsServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(SqlBackupRunsServiceClient.parse_common_folder_path)
    common_organization_path = staticmethod(SqlBackupRunsServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(SqlBackupRunsServiceClient.parse_common_organization_path)
    common_project_path = staticmethod(SqlBackupRunsServiceClient.common_project_path)
    parse_common_project_path = staticmethod(SqlBackupRunsServiceClient.parse_common_project_path)
    common_location_path = staticmethod(SqlBackupRunsServiceClient.common_location_path)
    parse_common_location_path = staticmethod(SqlBackupRunsServiceClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            SqlBackupRunsServiceAsyncClient: The constructed client.
        """
        return SqlBackupRunsServiceClient.from_service_account_info.__func__(SqlBackupRunsServiceAsyncClient, info, *args, **kwargs)  # type: ignore

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
            SqlBackupRunsServiceAsyncClient: The constructed client.
        """
        return SqlBackupRunsServiceClient.from_service_account_file.__func__(SqlBackupRunsServiceAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> SqlBackupRunsServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            SqlBackupRunsServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(SqlBackupRunsServiceClient).get_transport_class, type(SqlBackupRunsServiceClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, SqlBackupRunsServiceTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the sql backup runs service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.SqlBackupRunsServiceTransport]): The
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
        self._client = SqlBackupRunsServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def delete(self,
            request: Union[cloud_sql_backup_runs.SqlBackupRunsDeleteRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Deletes the backup taken by a backup run.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlBackupRunsDeleteRequest, dict]):
                The request object. Backup runs delete request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.sql_v1.types.Operation:
                An Operation resource.&nbsp;For
                successful operations that return an
                Operation resource, only the fields
                relevant to the operation are populated
                in the resource.

        """
        # Create or coerce a protobuf request object.
        request = cloud_sql_backup_runs.SqlBackupRunsDeleteRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete,
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

        # Done; return the response.
        return response

    async def get(self,
            request: Union[cloud_sql_backup_runs.SqlBackupRunsGetRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_backup_runs.BackupRun:
        r"""Retrieves a resource containing information about a
        backup run.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlBackupRunsGetRequest, dict]):
                The request object. Backup runs get request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.sql_v1.types.BackupRun:
                A BackupRun resource.
        """
        # Create or coerce a protobuf request object.
        request = cloud_sql_backup_runs.SqlBackupRunsGetRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get,
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

        # Done; return the response.
        return response

    async def insert(self,
            request: Union[cloud_sql_backup_runs.SqlBackupRunsInsertRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Creates a new backup run on demand.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlBackupRunsInsertRequest, dict]):
                The request object. Backup runs insert request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.sql_v1.types.Operation:
                An Operation resource.&nbsp;For
                successful operations that return an
                Operation resource, only the fields
                relevant to the operation are populated
                in the resource.

        """
        # Create or coerce a protobuf request object.
        request = cloud_sql_backup_runs.SqlBackupRunsInsertRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.insert,
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

        # Done; return the response.
        return response

    async def list(self,
            request: Union[cloud_sql_backup_runs.SqlBackupRunsListRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListAsyncPager:
        r"""Lists all backup runs associated with the project or
        a given instance and configuration in the reverse
        chronological order of the backup initiation time.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlBackupRunsListRequest, dict]):
                The request object. Backup runs list request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.sql_v1.services.sql_backup_runs_service.pagers.ListAsyncPager:
                Backup run list results.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = cloud_sql_backup_runs.SqlBackupRunsListRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list,
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
        response = pagers.ListAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def __aenter__(self):
        return self

    async def __aexit__(self, exc_type, exc, tb):
        await self.transport.close()

try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            "google-cloud-sql",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "SqlBackupRunsServiceAsyncClient",
)
