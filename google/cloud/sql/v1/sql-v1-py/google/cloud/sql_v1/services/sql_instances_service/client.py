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
import os
import re
from typing import Dict, Optional, Sequence, Tuple, Type, Union
import pkg_resources

from google.api_core import client_options as client_options_lib
from google.api_core import exceptions as core_exceptions
from google.api_core import gapic_v1
from google.api_core import retry as retries
from google.auth import credentials as ga_credentials             # type: ignore
from google.auth.transport import mtls                            # type: ignore
from google.auth.transport.grpc import SslCredentials             # type: ignore
from google.auth.exceptions import MutualTLSChannelError          # type: ignore
from google.oauth2 import service_account                         # type: ignore

try:
    OptionalRetry = Union[retries.Retry, gapic_v1.method._MethodDefault]
except AttributeError:  # pragma: NO COVER
    OptionalRetry = Union[retries.Retry, object]  # type: ignore

from google.cloud.sql_v1.services.sql_instances_service import pagers
from google.cloud.sql_v1.types import cloud_sql_instances
from google.cloud.sql_v1.types import cloud_sql_resources
from google.protobuf import timestamp_pb2  # type: ignore
from google.protobuf import wrappers_pb2  # type: ignore
from .transports.base import SqlInstancesServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc import SqlInstancesServiceGrpcTransport
from .transports.grpc_asyncio import SqlInstancesServiceGrpcAsyncIOTransport


class SqlInstancesServiceClientMeta(type):
    """Metaclass for the SqlInstancesService client.

    This provides class-level methods for building and retrieving
    support objects (e.g. transport) without polluting the client instance
    objects.
    """
    _transport_registry = OrderedDict()  # type: Dict[str, Type[SqlInstancesServiceTransport]]
    _transport_registry["grpc"] = SqlInstancesServiceGrpcTransport
    _transport_registry["grpc_asyncio"] = SqlInstancesServiceGrpcAsyncIOTransport

    def get_transport_class(cls,
            label: str = None,
        ) -> Type[SqlInstancesServiceTransport]:
        """Returns an appropriate transport class.

        Args:
            label: The name of the desired transport. If none is
                provided, then the first transport in the registry is used.

        Returns:
            The transport class to use.
        """
        # If a specific transport is requested, return that one.
        if label:
            return cls._transport_registry[label]

        # No transport is requested; return the default (that is, the first one
        # in the dictionary).
        return next(iter(cls._transport_registry.values()))


class SqlInstancesServiceClient(metaclass=SqlInstancesServiceClientMeta):
    """Service to manage Cloud SQL instances."""

    @staticmethod
    def _get_default_mtls_endpoint(api_endpoint):
        """Converts api endpoint to mTLS endpoint.

        Convert "*.sandbox.googleapis.com" and "*.googleapis.com" to
        "*.mtls.sandbox.googleapis.com" and "*.mtls.googleapis.com" respectively.
        Args:
            api_endpoint (Optional[str]): the api endpoint to convert.
        Returns:
            str: converted mTLS api endpoint.
        """
        if not api_endpoint:
            return api_endpoint

        mtls_endpoint_re = re.compile(
            r"(?P<name>[^.]+)(?P<mtls>\.mtls)?(?P<sandbox>\.sandbox)?(?P<googledomain>\.googleapis\.com)?"
        )

        m = mtls_endpoint_re.match(api_endpoint)
        name, mtls, sandbox, googledomain = m.groups()
        if mtls or not googledomain:
            return api_endpoint

        if sandbox:
            return api_endpoint.replace(
                "sandbox.googleapis.com", "mtls.sandbox.googleapis.com"
            )

        return api_endpoint.replace(".googleapis.com", ".mtls.googleapis.com")

    DEFAULT_ENDPOINT = "sqladmin.googleapis.com"
    DEFAULT_MTLS_ENDPOINT = _get_default_mtls_endpoint.__func__(  # type: ignore
        DEFAULT_ENDPOINT
    )

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            SqlInstancesServiceClient: The constructed client.
        """
        credentials = service_account.Credentials.from_service_account_info(info)
        kwargs["credentials"] = credentials
        return cls(*args, **kwargs)

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
            SqlInstancesServiceClient: The constructed client.
        """
        credentials = service_account.Credentials.from_service_account_file(
            filename)
        kwargs["credentials"] = credentials
        return cls(*args, **kwargs)

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> SqlInstancesServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            SqlInstancesServiceTransport: The transport used by the client
                instance.
        """
        return self._transport

    @staticmethod
    def common_billing_account_path(billing_account: str, ) -> str:
        """Returns a fully-qualified billing_account string."""
        return "billingAccounts/{billing_account}".format(billing_account=billing_account, )

    @staticmethod
    def parse_common_billing_account_path(path: str) -> Dict[str,str]:
        """Parse a billing_account path into its component segments."""
        m = re.match(r"^billingAccounts/(?P<billing_account>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_folder_path(folder: str, ) -> str:
        """Returns a fully-qualified folder string."""
        return "folders/{folder}".format(folder=folder, )

    @staticmethod
    def parse_common_folder_path(path: str) -> Dict[str,str]:
        """Parse a folder path into its component segments."""
        m = re.match(r"^folders/(?P<folder>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_organization_path(organization: str, ) -> str:
        """Returns a fully-qualified organization string."""
        return "organizations/{organization}".format(organization=organization, )

    @staticmethod
    def parse_common_organization_path(path: str) -> Dict[str,str]:
        """Parse a organization path into its component segments."""
        m = re.match(r"^organizations/(?P<organization>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_project_path(project: str, ) -> str:
        """Returns a fully-qualified project string."""
        return "projects/{project}".format(project=project, )

    @staticmethod
    def parse_common_project_path(path: str) -> Dict[str,str]:
        """Parse a project path into its component segments."""
        m = re.match(r"^projects/(?P<project>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_location_path(project: str, location: str, ) -> str:
        """Returns a fully-qualified location string."""
        return "projects/{project}/locations/{location}".format(project=project, location=location, )

    @staticmethod
    def parse_common_location_path(path: str) -> Dict[str,str]:
        """Parse a location path into its component segments."""
        m = re.match(r"^projects/(?P<project>.+?)/locations/(?P<location>.+?)$", path)
        return m.groupdict() if m else {}

    def __init__(self, *,
            credentials: Optional[ga_credentials.Credentials] = None,
            transport: Union[str, SqlInstancesServiceTransport, None] = None,
            client_options: Optional[client_options_lib.ClientOptions] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the sql instances service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, SqlInstancesServiceTransport]): The
                transport to use. If set to None, a transport is chosen
                automatically.
            client_options (google.api_core.client_options.ClientOptions): Custom options for the
                client. It won't take effect if a ``transport`` instance is provided.
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
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):
                The client info used to send a user-agent string along with
                API requests. If ``None``, then default info will be used.
                Generally, you only need to set this if you're developing
                your own client library.

        Raises:
            google.auth.exceptions.MutualTLSChannelError: If mutual TLS transport
                creation failed for any reason.
        """
        if isinstance(client_options, dict):
            client_options = client_options_lib.from_dict(client_options)
        if client_options is None:
            client_options = client_options_lib.ClientOptions()

        # Create SSL credentials for mutual TLS if needed.
        if os.getenv("GOOGLE_API_USE_CLIENT_CERTIFICATE", "false") not in ("true", "false"):
            raise ValueError("Environment variable `GOOGLE_API_USE_CLIENT_CERTIFICATE` must be either `true` or `false`")
        use_client_cert = os.getenv("GOOGLE_API_USE_CLIENT_CERTIFICATE", "false") == "true"

        client_cert_source_func = None
        is_mtls = False
        if use_client_cert:
            if client_options.client_cert_source:
                is_mtls = True
                client_cert_source_func = client_options.client_cert_source
            else:
                is_mtls = mtls.has_default_client_cert_source()
                if is_mtls:
                    client_cert_source_func = mtls.default_client_cert_source()
                else:
                    client_cert_source_func = None

        # Figure out which api endpoint to use.
        if client_options.api_endpoint is not None:
            api_endpoint = client_options.api_endpoint
        else:
            use_mtls_env = os.getenv("GOOGLE_API_USE_MTLS_ENDPOINT", "auto")
            if use_mtls_env == "never":
                api_endpoint = self.DEFAULT_ENDPOINT
            elif use_mtls_env == "always":
                api_endpoint = self.DEFAULT_MTLS_ENDPOINT
            elif use_mtls_env == "auto":
                if is_mtls:
                    api_endpoint = self.DEFAULT_MTLS_ENDPOINT
                else:
                    api_endpoint = self.DEFAULT_ENDPOINT
            else:
                raise MutualTLSChannelError(
                    "Unsupported GOOGLE_API_USE_MTLS_ENDPOINT value. Accepted "
                    "values: never, auto, always"
                )

        # Save or instantiate the transport.
        # Ordinarily, we provide the transport, but allowing a custom transport
        # instance provides an extensibility point for unusual situations.
        if isinstance(transport, SqlInstancesServiceTransport):
            # transport is a SqlInstancesServiceTransport instance.
            if credentials or client_options.credentials_file:
                raise ValueError("When providing a transport instance, "
                                 "provide its credentials directly.")
            if client_options.scopes:
                raise ValueError(
                    "When providing a transport instance, provide its scopes "
                    "directly."
                )
            self._transport = transport
        else:
            Transport = type(self).get_transport_class(transport)
            self._transport = Transport(
                credentials=credentials,
                credentials_file=client_options.credentials_file,
                host=api_endpoint,
                scopes=client_options.scopes,
                client_cert_source_for_mtls=client_cert_source_func,
                quota_project_id=client_options.quota_project_id,
                client_info=client_info,
                always_use_jwt_access=True,
            )

    def add_server_ca(self,
            request: Union[cloud_sql_instances.SqlInstancesAddServerCaRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
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
            request (Union[google.cloud.sql_v1.types.SqlInstancesAddServerCaRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesAddServerCaRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesAddServerCaRequest):
            request = cloud_sql_instances.SqlInstancesAddServerCaRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.add_server_ca]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def clone(self,
            request: Union[cloud_sql_instances.SqlInstancesCloneRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Creates a Cloud SQL instance as a clone of the source
        instance. Using this operation might cause your instance
        to restart.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesCloneRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesCloneRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesCloneRequest):
            request = cloud_sql_instances.SqlInstancesCloneRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.clone]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def delete(self,
            request: Union[cloud_sql_instances.SqlInstancesDeleteRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Deletes a Cloud SQL instance.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesDeleteRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesDeleteRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesDeleteRequest):
            request = cloud_sql_instances.SqlInstancesDeleteRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def demote_master(self,
            request: Union[cloud_sql_instances.SqlInstancesDemoteMasterRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Demotes the stand-alone instance to be a Cloud SQL
        read replica for an external database server.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesDemoteMasterRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesDemoteMasterRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesDemoteMasterRequest):
            request = cloud_sql_instances.SqlInstancesDemoteMasterRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.demote_master]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def export(self,
            request: Union[cloud_sql_instances.SqlInstancesExportRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Exports data from a Cloud SQL instance to a Cloud
        Storage bucket as a SQL dump or CSV file.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesExportRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesExportRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesExportRequest):
            request = cloud_sql_instances.SqlInstancesExportRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.export]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def failover(self,
            request: Union[cloud_sql_instances.SqlInstancesFailoverRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
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
            request (Union[google.cloud.sql_v1.types.SqlInstancesFailoverRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesFailoverRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesFailoverRequest):
            request = cloud_sql_instances.SqlInstancesFailoverRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.failover]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def get(self,
            request: Union[cloud_sql_instances.SqlInstancesGetRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_instances.DatabaseInstance:
        r"""Retrieves a resource containing information about a
        Cloud SQL instance.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesGetRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesGetRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesGetRequest):
            request = cloud_sql_instances.SqlInstancesGetRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def import(self,
            request: Union[cloud_sql_instances.SqlInstancesImportRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Imports data into a Cloud SQL instance from a SQL
        dump  or CSV file in Cloud Storage.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesImportRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesImportRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesImportRequest):
            request = cloud_sql_instances.SqlInstancesImportRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.import]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def insert(self,
            request: Union[cloud_sql_instances.SqlInstancesInsertRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Creates a new Cloud SQL instance.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesInsertRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesInsertRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesInsertRequest):
            request = cloud_sql_instances.SqlInstancesInsertRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.insert]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def list(self,
            request: Union[cloud_sql_instances.SqlInstancesListRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListPager:
        r"""Lists instances under a given project.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesListRequest, dict]):
                The request object. Instance list request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.sql_v1.services.sql_instances_service.pagers.ListPager:
                Database instances list response.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesListRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesListRequest):
            request = cloud_sql_instances.SqlInstancesListRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__iter__` convenience method.
        response = pagers.ListPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def list_server_cas(self,
            request: Union[cloud_sql_instances.SqlInstancesListServerCasRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
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
            request (Union[google.cloud.sql_v1.types.SqlInstancesListServerCasRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesListServerCasRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesListServerCasRequest):
            request = cloud_sql_instances.SqlInstancesListServerCasRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_server_cas]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def patch(self,
            request: Union[cloud_sql_instances.SqlInstancesPatchRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Updates settings of a Cloud SQL instance.
        This method supports patch semantics.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesPatchRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesPatchRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesPatchRequest):
            request = cloud_sql_instances.SqlInstancesPatchRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.patch]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def promote_replica(self,
            request: Union[cloud_sql_instances.SqlInstancesPromoteReplicaRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Promotes the read replica instance to be a stand-
        lone Cloud SQL instance. Using this operation might
        cause your instance to restart.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesPromoteReplicaRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesPromoteReplicaRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesPromoteReplicaRequest):
            request = cloud_sql_instances.SqlInstancesPromoteReplicaRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.promote_replica]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def reset_ssl_config(self,
            request: Union[cloud_sql_instances.SqlInstancesResetSslConfigRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Deletes all client certificates and generates a new
        server SSL certificate for the instance.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesResetSslConfigRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesResetSslConfigRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesResetSslConfigRequest):
            request = cloud_sql_instances.SqlInstancesResetSslConfigRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.reset_ssl_config]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def restart(self,
            request: Union[cloud_sql_instances.SqlInstancesRestartRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Restarts a Cloud SQL instance.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesRestartRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesRestartRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesRestartRequest):
            request = cloud_sql_instances.SqlInstancesRestartRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.restart]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def restore_backup(self,
            request: Union[cloud_sql_instances.SqlInstancesRestoreBackupRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Restores a backup of a Cloud SQL instance. Using this
        operation might cause your instance to restart.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesRestoreBackupRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesRestoreBackupRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesRestoreBackupRequest):
            request = cloud_sql_instances.SqlInstancesRestoreBackupRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.restore_backup]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def rotate_server_ca(self,
            request: Union[cloud_sql_instances.SqlInstancesRotateServerCaRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Rotates the server certificate to one signed by the
        Certificate Authority (CA) version previously added with
        the addServerCA method.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesRotateServerCaRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesRotateServerCaRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesRotateServerCaRequest):
            request = cloud_sql_instances.SqlInstancesRotateServerCaRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.rotate_server_ca]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def start_replica(self,
            request: Union[cloud_sql_instances.SqlInstancesStartReplicaRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Starts the replication in the read replica instance.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesStartReplicaRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesStartReplicaRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesStartReplicaRequest):
            request = cloud_sql_instances.SqlInstancesStartReplicaRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.start_replica]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def stop_replica(self,
            request: Union[cloud_sql_instances.SqlInstancesStopReplicaRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Stops the replication in the read replica instance.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesStopReplicaRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesStopReplicaRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesStopReplicaRequest):
            request = cloud_sql_instances.SqlInstancesStopReplicaRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.stop_replica]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def truncate_log(self,
            request: Union[cloud_sql_instances.SqlInstancesTruncateLogRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Truncate MySQL general and slow query log tables
        MySQL only.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesTruncateLogRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesTruncateLogRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesTruncateLogRequest):
            request = cloud_sql_instances.SqlInstancesTruncateLogRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.truncate_log]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def update(self,
            request: Union[cloud_sql_instances.SqlInstancesUpdateRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Updates settings of a Cloud SQL instance. Using this
        operation might cause your instance to restart.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesUpdateRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesUpdateRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesUpdateRequest):
            request = cloud_sql_instances.SqlInstancesUpdateRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def create_ephemeral(self,
            request: Union[cloud_sql_instances.SqlInstancesCreateEphemeralCertRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.SslCert:
        r"""Generates a short-lived X509 certificate containing
        the provided public key and signed by a private key
        specific to the target instance. Users may use the
        certificate to authenticate as themselves when
        connecting to the database.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesCreateEphemeralCertRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesCreateEphemeralCertRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesCreateEphemeralCertRequest):
            request = cloud_sql_instances.SqlInstancesCreateEphemeralCertRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.create_ephemeral]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def reschedule_maintenance(self,
            request: Union[cloud_sql_instances.SqlInstancesRescheduleMaintenanceRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Reschedules the maintenance on the given instance.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesRescheduleMaintenanceRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesRescheduleMaintenanceRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesRescheduleMaintenanceRequest):
            request = cloud_sql_instances.SqlInstancesRescheduleMaintenanceRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.reschedule_maintenance]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def verify_external_sync_settings(self,
            request: Union[cloud_sql_instances.SqlInstancesVerifyExternalSyncSettingsRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_instances.SqlInstancesVerifyExternalSyncSettingsResponse:
        r"""Verify External primary instance external sync
        settings.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesVerifyExternalSyncSettingsRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesVerifyExternalSyncSettingsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesVerifyExternalSyncSettingsRequest):
            request = cloud_sql_instances.SqlInstancesVerifyExternalSyncSettingsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.verify_external_sync_settings]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def start_external_sync(self,
            request: Union[cloud_sql_instances.SqlInstancesStartExternalSyncRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> cloud_sql_resources.Operation:
        r"""Start External primary instance migration.

        Args:
            request (Union[google.cloud.sql_v1.types.SqlInstancesStartExternalSyncRequest, dict]):
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
        # Minor optimization to avoid making a copy if the user passes
        # in a cloud_sql_instances.SqlInstancesStartExternalSyncRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, cloud_sql_instances.SqlInstancesStartExternalSyncRequest):
            request = cloud_sql_instances.SqlInstancesStartExternalSyncRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.start_external_sync]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def __enter__(self):
        return self

    def __exit__(self, type, value, traceback):
        """Releases underlying transport's resources.

        .. warning::
            ONLY use as a context manager if the transport is NOT shared
            with other clients! Exiting the with block will CLOSE the transport
            and may cause errors in other clients!
        """
        self.transport.close()



try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            "google-cloud-sql",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "SqlInstancesServiceClient",
)
