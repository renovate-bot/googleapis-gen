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

from google.cloud.sql_v1.services.sql_instances_service import pagers
from google.cloud.sql_v1.types import cloud_sql_instances
from google.cloud.sql_v1.types import cloud_sql_resources
from google.protobuf import timestamp_pb2  # type: ignore
from google.protobuf import wrappers_pb2  # type: ignore
from .transports.base import SqlInstancesServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import SqlInstancesServiceGrpcAsyncIOTransport
from .client import SqlInstancesServiceClient


class SqlInstancesServiceAsyncClient:
    """Service to manage Cloud SQL instances."""

    _client: SqlInstancesServiceClient

    DEFAULT_ENDPOINT = SqlInstancesServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = SqlInstancesServiceClient.DEFAULT_MTLS_ENDPOINT

    common_billing_account_path = staticmethod(SqlInstancesServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(SqlInstancesServiceClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(SqlInstancesServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(SqlInstancesServiceClient.parse_common_folder_path)
    common_organization_path = staticmethod(SqlInstancesServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(SqlInstancesServiceClient.parse_common_organization_path)
    common_project_path = staticmethod(SqlInstancesServiceClient.common_project_path)
    parse_common_project_path = staticmethod(SqlInstancesServiceClient.parse_common_project_path)
    common_location_path = staticmethod(SqlInstancesServiceClient.common_location_path)
    parse_common_location_path = staticmethod(SqlInstancesServiceClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            SqlInstancesServiceAsyncClient: The constructed client.
        """
        return SqlInstancesServiceClient.from_service_account_info.__func__(SqlInstancesServiceAsyncClient, info, *args, **kwargs)  # type: ignore

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
            SqlInstancesServiceAsyncClient: The constructed client.
        """
        return SqlInstancesServiceClient.from_service_account_file.__func__(SqlInstancesServiceAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> SqlInstancesServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            SqlInstancesServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(SqlInstancesServiceClient).get_transport_class, type(SqlInstancesServiceClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, SqlInstancesServiceTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the sql instances service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.SqlInstancesServiceTransport]): The
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
        self._client = SqlInstancesServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def add_server_ca(self,
            request: cloud_sql_instances.SqlInstancesAddServerCaRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Adds a new trusted Certificate Authority (CA) version
        for the specified instance. Required to prepare for a
        certificate rotation. If a CA version was previously
        added but never used in a certificate rotation, this
        operation replaces that version. There cannot be more
        than one CA version waiting to be rotated in.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesAddServerCaRequest`):
                The request object. Instance add server CA request.
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
        request = cloud_sql_instances.SqlInstancesAddServerCaRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.add_server_ca,
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

    async def clone(self,
            request: cloud_sql_instances.SqlInstancesCloneRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Creates a Cloud SQL instance as a clone of the source
        instance. Using this operation might cause your instance
        to restart.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesCloneRequest`):
                The request object. Instance clone request.
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
        request = cloud_sql_instances.SqlInstancesCloneRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.clone,
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

    async def delete(self,
            request: cloud_sql_instances.SqlInstancesDeleteRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Deletes a Cloud SQL instance.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesDeleteRequest`):
                The request object. Instance delete request.
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
        request = cloud_sql_instances.SqlInstancesDeleteRequest(request)

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

    async def demote_master(self,
            request: cloud_sql_instances.SqlInstancesDemoteMasterRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Demotes the stand-alone instance to be a Cloud SQL
        read replica for an external database server.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesDemoteMasterRequest`):
                The request object. Instance demote master request.
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
        request = cloud_sql_instances.SqlInstancesDemoteMasterRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.demote_master,
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

    async def export(self,
            request: cloud_sql_instances.SqlInstancesExportRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Exports data from a Cloud SQL instance to a Cloud
        Storage bucket as a SQL dump or CSV file.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesExportRequest`):
                The request object. Instance export request.
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
        request = cloud_sql_instances.SqlInstancesExportRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.export,
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

    async def failover(self,
            request: cloud_sql_instances.SqlInstancesFailoverRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Initiates a manual failover of a high availability (HA) primary
        instance to a standby instance, which becomes the primary
        instance. Users are then rerouted to the new primary. For more
        information, see the `Overview of high
        availability <https://cloud.google.com/sql/docs/mysql/high-availability>`__
        page in the Cloud SQL documentation. If using Legacy HA (MySQL
        only), this causes the instance to failover to its failover
        replica instance.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesFailoverRequest`):
                The request object. Instance failover request.
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
        request = cloud_sql_instances.SqlInstancesFailoverRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.failover,
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
            request: cloud_sql_instances.SqlInstancesGetRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_instances.DatabaseInstance:
        r"""Retrieves a resource containing information about a
        Cloud SQL instance.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesGetRequest`):
                The request object. Instance get request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.sql_v1.types.DatabaseInstance:
                A Cloud SQL instance resource.
        """
        # Create or coerce a protobuf request object.
        request = cloud_sql_instances.SqlInstancesGetRequest(request)

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

    async def import(self,
            request: cloud_sql_instances.SqlInstancesImportRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Imports data into a Cloud SQL instance from a SQL
        dump  or CSV file in Cloud Storage.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesImportRequest`):
                The request object. Instance import request.
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
        request = cloud_sql_instances.SqlInstancesImportRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.import,
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
            request: cloud_sql_instances.SqlInstancesInsertRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Creates a new Cloud SQL instance.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesInsertRequest`):
                The request object. Instance insert request.
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
        request = cloud_sql_instances.SqlInstancesInsertRequest(request)

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
            request: cloud_sql_instances.SqlInstancesListRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListAsyncPager:
        r"""Lists instances under a given project.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesListRequest`):
                The request object. Instance list request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.sql_v1.services.sql_instances_service.pagers.ListAsyncPager:
                Database instances list response.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = cloud_sql_instances.SqlInstancesListRequest(request)

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

    async def list_server_cas(self,
            request: cloud_sql_instances.SqlInstancesListServerCasRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_instances.InstancesListServerCasResponse:
        r"""Lists all of the trusted Certificate Authorities
        (CAs) for the specified instance. There can be up to
        three CAs listed: the CA that was used to sign the
        certificate that is currently in use, a CA that has been
        added but not yet used to sign a certificate, and a CA
        used to sign a certificate that has previously rotated
        out.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesListServerCasRequest`):
                The request object. Instance list server CAs request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.sql_v1.types.InstancesListServerCasResponse:
                Instances ListServerCas response.
        """
        # Create or coerce a protobuf request object.
        request = cloud_sql_instances.SqlInstancesListServerCasRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_server_cas,
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

    async def patch(self,
            request: cloud_sql_instances.SqlInstancesPatchRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Updates settings of a Cloud SQL instance.
        This method supports patch semantics.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesPatchRequest`):
                The request object. Instance patch request.
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
        request = cloud_sql_instances.SqlInstancesPatchRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.patch,
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

    async def promote_replica(self,
            request: cloud_sql_instances.SqlInstancesPromoteReplicaRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Promotes the read replica instance to be a stand-
        lone Cloud SQL instance. Using this operation might
        cause your instance to restart.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesPromoteReplicaRequest`):
                The request object. Instance promote replica request.
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
        request = cloud_sql_instances.SqlInstancesPromoteReplicaRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.promote_replica,
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

    async def reset_ssl_config(self,
            request: cloud_sql_instances.SqlInstancesResetSslConfigRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Deletes all client certificates and generates a new
        server SSL certificate for the instance.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesResetSslConfigRequest`):
                The request object. Instance reset SSL config request.
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
        request = cloud_sql_instances.SqlInstancesResetSslConfigRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.reset_ssl_config,
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

    async def restart(self,
            request: cloud_sql_instances.SqlInstancesRestartRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Restarts a Cloud SQL instance.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesRestartRequest`):
                The request object. Instance restart request.
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
        request = cloud_sql_instances.SqlInstancesRestartRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.restart,
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

    async def restore_backup(self,
            request: cloud_sql_instances.SqlInstancesRestoreBackupRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Restores a backup of a Cloud SQL instance. Using this
        operation might cause your instance to restart.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesRestoreBackupRequest`):
                The request object. Instance restore backup request.
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
        request = cloud_sql_instances.SqlInstancesRestoreBackupRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.restore_backup,
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

    async def rotate_server_ca(self,
            request: cloud_sql_instances.SqlInstancesRotateServerCaRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Rotates the server certificate to one signed by the
        Certificate Authority (CA) version previously added with
        the addServerCA method.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesRotateServerCaRequest`):
                The request object. Instance rotate server CA request.
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
        request = cloud_sql_instances.SqlInstancesRotateServerCaRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.rotate_server_ca,
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

    async def start_replica(self,
            request: cloud_sql_instances.SqlInstancesStartReplicaRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Starts the replication in the read replica instance.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesStartReplicaRequest`):
                The request object. Instance start replica request.
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
        request = cloud_sql_instances.SqlInstancesStartReplicaRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.start_replica,
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

    async def stop_replica(self,
            request: cloud_sql_instances.SqlInstancesStopReplicaRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Stops the replication in the read replica instance.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesStopReplicaRequest`):
                The request object. Instance stop replica request.
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
        request = cloud_sql_instances.SqlInstancesStopReplicaRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.stop_replica,
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

    async def truncate_log(self,
            request: cloud_sql_instances.SqlInstancesTruncateLogRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Truncate MySQL general and slow query log tables
        MySQL only.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesTruncateLogRequest`):
                The request object. Instance truncate log request.
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
        request = cloud_sql_instances.SqlInstancesTruncateLogRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.truncate_log,
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

    async def update(self,
            request: cloud_sql_instances.SqlInstancesUpdateRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Updates settings of a Cloud SQL instance. Using this
        operation might cause your instance to restart.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesUpdateRequest`):
                The request object. Instance update request.
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
        request = cloud_sql_instances.SqlInstancesUpdateRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update,
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

    async def create_ephemeral(self,
            request: cloud_sql_instances.SqlInstancesCreateEphemeralCertRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.SslCert:
        r"""Generates a short-lived X509 certificate containing
        the provided public key and signed by a private key
        specific to the target instance. Users may use the
        certificate to authenticate as themselves when
        connecting to the database.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesCreateEphemeralCertRequest`):
                The request object. Instance create ephemeral
                certificate request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.sql_v1.types.SslCert:
                SslCerts Resource
        """
        # Create or coerce a protobuf request object.
        request = cloud_sql_instances.SqlInstancesCreateEphemeralCertRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_ephemeral,
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

    async def reschedule_maintenance(self,
            request: cloud_sql_instances.SqlInstancesRescheduleMaintenanceRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Reschedules the maintenance on the given instance.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesRescheduleMaintenanceRequest`):
                The request object. Instance reschedule maintenance
                request.
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
        request = cloud_sql_instances.SqlInstancesRescheduleMaintenanceRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.reschedule_maintenance,
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

    async def verify_external_sync_settings(self,
            request: cloud_sql_instances.SqlInstancesVerifyExternalSyncSettingsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_instances.SqlInstancesVerifyExternalSyncSettingsResponse:
        r"""Verify External primary instance external sync
        settings.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesVerifyExternalSyncSettingsRequest`):
                The request object. Instance verify external sync
                settings request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.sql_v1.types.SqlInstancesVerifyExternalSyncSettingsResponse:
                Instance verify external sync
                settings response.

        """
        # Create or coerce a protobuf request object.
        request = cloud_sql_instances.SqlInstancesVerifyExternalSyncSettingsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.verify_external_sync_settings,
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

    async def start_external_sync(self,
            request: cloud_sql_instances.SqlInstancesStartExternalSyncRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Start External primary instance migration.

        Args:
            request (:class:`google.cloud.sql_v1.types.SqlInstancesStartExternalSyncRequest`):
                The request object. Instance start external sync
                request.
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
        request = cloud_sql_instances.SqlInstancesStartExternalSyncRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.start_external_sync,
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





try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            "google-cloud-sql",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "SqlInstancesServiceAsyncClient",
)
