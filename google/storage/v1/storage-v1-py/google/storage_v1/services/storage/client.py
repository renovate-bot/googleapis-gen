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
from distutils import util
import os
import re
from typing import Callable, Dict, Optional, Iterable, Iterator, Sequence, Tuple, Type, Union
import pkg_resources

from google.api_core import client_options as client_options_lib  # type: ignore
from google.api_core import exceptions                            # type: ignore
from google.api_core import gapic_v1                              # type: ignore
from google.api_core import retry as retries                      # type: ignore
from google.auth import credentials                               # type: ignore
from google.auth.transport import mtls                            # type: ignore
from google.auth.transport.grpc import SslCredentials             # type: ignore
from google.auth.exceptions import MutualTLSChannelError          # type: ignore
from google.oauth2 import service_account                         # type: ignore

from google.iam.v1 import iam_policy_pb2 as iam_policy  # type: ignore
from google.iam.v1 import policy_pb2 as gi_policy  # type: ignore
from google.protobuf import timestamp_pb2 as timestamp  # type: ignore
from google.protobuf import wrappers_pb2 as wrappers  # type: ignore
from google.storage_v1.services.storage import pagers
from google.storage_v1.types import storage
from google.storage_v1.types import storage_resources

from .transports.base import StorageTransport, DEFAULT_CLIENT_INFO
from .transports.grpc import StorageGrpcTransport
from .transports.grpc_asyncio import StorageGrpcAsyncIOTransport


class StorageClientMeta(type):
    """Metaclass for the Storage client.

    This provides class-level methods for building and retrieving
    support objects (e.g. transport) without polluting the client instance
    objects.
    """
    _transport_registry = OrderedDict()  # type: Dict[str, Type[StorageTransport]]
    _transport_registry['grpc'] = StorageGrpcTransport
    _transport_registry['grpc_asyncio'] = StorageGrpcAsyncIOTransport

    def get_transport_class(cls,
            label: str = None,
        ) -> Type[StorageTransport]:
        """Return an appropriate transport class.

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


class StorageClient(metaclass=StorageClientMeta):
    """Manages Google Cloud Storage resources."""

    @staticmethod
    def _get_default_mtls_endpoint(api_endpoint):
        """Convert api endpoint to mTLS endpoint.
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

    DEFAULT_ENDPOINT = 'storage.googleapis.com'
    DEFAULT_MTLS_ENDPOINT = _get_default_mtls_endpoint.__func__(  # type: ignore
        DEFAULT_ENDPOINT
    )

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            StorageClient: The constructed client.
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
            StorageClient: The constructed client.
        """
        credentials = service_account.Credentials.from_service_account_file(
            filename)
        kwargs['credentials'] = credentials
        return cls(*args, **kwargs)

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> StorageTransport:
        """Return the transport used by the client instance.

        Returns:
            StorageTransport: The transport used by the client instance.
        """
        return self._transport

    @staticmethod
    def common_billing_account_path(billing_account: str, ) -> str:
        """Return a fully-qualified billing_account string."""
        return "billingAccounts/{billing_account}".format(billing_account=billing_account, )

    @staticmethod
    def parse_common_billing_account_path(path: str) -> Dict[str,str]:
        """Parse a billing_account path into its component segments."""
        m = re.match(r"^billingAccounts/(?P<billing_account>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_folder_path(folder: str, ) -> str:
        """Return a fully-qualified folder string."""
        return "folders/{folder}".format(folder=folder, )

    @staticmethod
    def parse_common_folder_path(path: str) -> Dict[str,str]:
        """Parse a folder path into its component segments."""
        m = re.match(r"^folders/(?P<folder>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_organization_path(organization: str, ) -> str:
        """Return a fully-qualified organization string."""
        return "organizations/{organization}".format(organization=organization, )

    @staticmethod
    def parse_common_organization_path(path: str) -> Dict[str,str]:
        """Parse a organization path into its component segments."""
        m = re.match(r"^organizations/(?P<organization>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_project_path(project: str, ) -> str:
        """Return a fully-qualified project string."""
        return "projects/{project}".format(project=project, )

    @staticmethod
    def parse_common_project_path(path: str) -> Dict[str,str]:
        """Parse a project path into its component segments."""
        m = re.match(r"^projects/(?P<project>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_location_path(project: str, location: str, ) -> str:
        """Return a fully-qualified location string."""
        return "projects/{project}/locations/{location}".format(project=project, location=location, )

    @staticmethod
    def parse_common_location_path(path: str) -> Dict[str,str]:
        """Parse a location path into its component segments."""
        m = re.match(r"^projects/(?P<project>.+?)/locations/(?P<location>.+?)$", path)
        return m.groupdict() if m else {}

    def __init__(self, *,
            credentials: Optional[credentials.Credentials] = None,
            transport: Union[str, StorageTransport, None] = None,
            client_options: Optional[client_options_lib.ClientOptions] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiate the storage client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, StorageTransport]): The
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
        use_client_cert = bool(util.strtobool(os.getenv("GOOGLE_API_USE_CLIENT_CERTIFICATE", "false")))

        client_cert_source_func = None
        is_mtls = False
        if use_client_cert:
            if client_options.client_cert_source:
                is_mtls = True
                client_cert_source_func = client_options.client_cert_source
            else:
                is_mtls = mtls.has_default_client_cert_source()
                client_cert_source_func = mtls.default_client_cert_source() if is_mtls else None

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
                api_endpoint = self.DEFAULT_MTLS_ENDPOINT if is_mtls else self.DEFAULT_ENDPOINT
            else:
                raise MutualTLSChannelError(
                    "Unsupported GOOGLE_API_USE_MTLS_ENDPOINT value. Accepted values: never, auto, always"
                )

        # Save or instantiate the transport.
        # Ordinarily, we provide the transport, but allowing a custom transport
        # instance provides an extensibility point for unusual situations.
        if isinstance(transport, StorageTransport):
            # transport is a StorageTransport instance.
            if credentials or client_options.credentials_file:
                raise ValueError('When providing a transport instance, '
                                 'provide its credentials directly.')
            if client_options.scopes:
                raise ValueError(
                    "When providing a transport instance, "
                    "provide its scopes directly."
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
            )

    def delete_bucket_access_control(self,
            request: storage.DeleteBucketAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Permanently deletes the ACL entry for the specified
        entity on the specified bucket.

        Args:
            request (google.storage_v1.types.DeleteBucketAccessControlRequest):
                The request object. Request message for
                DeleteBucketAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.DeleteBucketAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.DeleteBucketAccessControlRequest):
            request = storage.DeleteBucketAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete_bucket_access_control]

        # Send the request.
        rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    def get_bucket_access_control(self,
            request: storage.GetBucketAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.BucketAccessControl:
        r"""Returns the ACL entry for the specified entity on the
        specified bucket.

        Args:
            request (google.storage_v1.types.GetBucketAccessControlRequest):
                The request object. Request message for
                GetBucketAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.BucketAccessControl:
                An access-control entry.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.GetBucketAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.GetBucketAccessControlRequest):
            request = storage.GetBucketAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_bucket_access_control]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def insert_bucket_access_control(self,
            request: storage.InsertBucketAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.BucketAccessControl:
        r"""Creates a new ACL entry on the specified bucket.

        Args:
            request (google.storage_v1.types.InsertBucketAccessControlRequest):
                The request object. Request message for
                InsertBucketAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.BucketAccessControl:
                An access-control entry.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.InsertBucketAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.InsertBucketAccessControlRequest):
            request = storage.InsertBucketAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.insert_bucket_access_control]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def list_bucket_access_controls(self,
            request: storage.ListBucketAccessControlsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.ListBucketAccessControlsResponse:
        r"""Retrieves ACL entries on the specified bucket.

        Args:
            request (google.storage_v1.types.ListBucketAccessControlsRequest):
                The request object. Request message for
                ListBucketAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.ListBucketAccessControlsResponse:
                The response to a call to
                BucketAccessControls.ListBucketAccessControls.

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.ListBucketAccessControlsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.ListBucketAccessControlsRequest):
            request = storage.ListBucketAccessControlsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_bucket_access_controls]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def update_bucket_access_control(self,
            request: storage.UpdateBucketAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.BucketAccessControl:
        r"""Updates an ACL entry on the specified bucket.
        Equivalent to PatchBucketAccessControl, but all
        unspecified fields will be reset to their default
        values.

        Args:
            request (google.storage_v1.types.UpdateBucketAccessControlRequest):
                The request object. Request for
                UpdateBucketAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.BucketAccessControl:
                An access-control entry.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.UpdateBucketAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.UpdateBucketAccessControlRequest):
            request = storage.UpdateBucketAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_bucket_access_control]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def patch_bucket_access_control(self,
            request: storage.PatchBucketAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.BucketAccessControl:
        r"""Updates an ACL entry on the specified bucket.

        Args:
            request (google.storage_v1.types.PatchBucketAccessControlRequest):
                The request object. Request for
                PatchBucketAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.BucketAccessControl:
                An access-control entry.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.PatchBucketAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.PatchBucketAccessControlRequest):
            request = storage.PatchBucketAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.patch_bucket_access_control]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def delete_bucket(self,
            request: storage.DeleteBucketRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Permanently deletes an empty bucket.

        Args:
            request (google.storage_v1.types.DeleteBucketRequest):
                The request object. Request message for DeleteBucket.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.DeleteBucketRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.DeleteBucketRequest):
            request = storage.DeleteBucketRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete_bucket]

        # Send the request.
        rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    def get_bucket(self,
            request: storage.GetBucketRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.Bucket:
        r"""Returns metadata for the specified bucket.

        Args:
            request (google.storage_v1.types.GetBucketRequest):
                The request object. Request message for GetBucket.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.Bucket:
                A bucket.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.GetBucketRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.GetBucketRequest):
            request = storage.GetBucketRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_bucket]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def insert_bucket(self,
            request: storage.InsertBucketRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.Bucket:
        r"""Creates a new bucket.

        Args:
            request (google.storage_v1.types.InsertBucketRequest):
                The request object. Request message for InsertBucket.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.Bucket:
                A bucket.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.InsertBucketRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.InsertBucketRequest):
            request = storage.InsertBucketRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.insert_bucket]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def list_channels(self,
            request: storage.ListChannelsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.ListChannelsResponse:
        r"""List active object change notification channels for
        this bucket.

        Args:
            request (google.storage_v1.types.ListChannelsRequest):
                The request object. Request message for ListChannels.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.ListChannelsResponse:
                The result of a call to
                Channels.ListChannels

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.ListChannelsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.ListChannelsRequest):
            request = storage.ListChannelsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_channels]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def list_buckets(self,
            request: storage.ListBucketsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListBucketsPager:
        r"""Retrieves a list of buckets for a given project.

        Args:
            request (google.storage_v1.types.ListBucketsRequest):
                The request object. Request message for ListBuckets.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.services.storage.pagers.ListBucketsPager:
                The result of a call to
                Buckets.ListBuckets
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.ListBucketsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.ListBucketsRequest):
            request = storage.ListBucketsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_buckets]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__iter__` convenience method.
        response = pagers.ListBucketsPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def lock_bucket_retention_policy(self,
            request: storage.LockRetentionPolicyRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.Bucket:
        r"""Locks retention policy on a bucket.

        Args:
            request (google.storage_v1.types.LockRetentionPolicyRequest):
                The request object. Request message for
                LockRetentionPolicy.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.Bucket:
                A bucket.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.LockRetentionPolicyRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.LockRetentionPolicyRequest):
            request = storage.LockRetentionPolicyRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.lock_bucket_retention_policy]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def get_bucket_iam_policy(self,
            request: storage.GetIamPolicyRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> gi_policy.Policy:
        r"""Gets the IAM policy for the specified bucket.

        Args:
            request (google.storage_v1.types.GetIamPolicyRequest):
                The request object. A wrapper around the IAM get policy
                request to support our common_request_params.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.v1.policy_pb2.Policy:
                Defines an Identity and Access Management (IAM) policy. It is used to
                   specify access control policies for Cloud Platform
                   resources.

                   A Policy is a collection of bindings. A binding binds
                   one or more members to a single role. Members can be
                   user accounts, service accounts, Google groups, and
                   domains (such as G Suite). A role is a named list of
                   permissions (defined by IAM or configured by users).
                   A binding can optionally specify a condition, which
                   is a logic expression that further constrains the
                   role binding based on attributes about the request
                   and/or target resource.

                   **JSON Example**

                      {
                         "bindings": [
                            {
                               "role":
                               "roles/resourcemanager.organizationAdmin",
                               "members": [ "user:mike@example.com",
                               "group:admins@example.com",
                               "domain:google.com",
                               "serviceAccount:my-project-id@appspot.gserviceaccount.com"
                               ]

                            }, { "role":
                            "roles/resourcemanager.organizationViewer",
                            "members": ["user:eve@example.com"],
                            "condition": { "title": "expirable access",
                            "description": "Does not grant access after
                            Sep 2020", "expression": "request.time <
                            timestamp('2020-10-01T00:00:00.000Z')", } }

                         ]

                      }

                   **YAML Example**

                      bindings: - members: - user:\ mike@example.com -
                      group:\ admins@example.com - domain:google.com -
                      serviceAccount:\ my-project-id@appspot.gserviceaccount.com
                      role: roles/resourcemanager.organizationAdmin -
                      members: - user:\ eve@example.com role:
                      roles/resourcemanager.organizationViewer
                      condition: title: expirable access description:
                      Does not grant access after Sep 2020 expression:
                      request.time <
                      timestamp('2020-10-01T00:00:00.000Z')

                   For a description of IAM and its features, see the
                   [IAM developer's
                   guide](\ https://cloud.google.com/iam/docs).

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.GetIamPolicyRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.GetIamPolicyRequest):
            request = storage.GetIamPolicyRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_bucket_iam_policy]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def set_bucket_iam_policy(self,
            request: storage.SetIamPolicyRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> gi_policy.Policy:
        r"""Updates an IAM policy for the specified bucket.

        Args:
            request (google.storage_v1.types.SetIamPolicyRequest):
                The request object. A wrapper around the IAM set policy
                request to support our common_request_params.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.v1.policy_pb2.Policy:
                Defines an Identity and Access Management (IAM) policy. It is used to
                   specify access control policies for Cloud Platform
                   resources.

                   A Policy is a collection of bindings. A binding binds
                   one or more members to a single role. Members can be
                   user accounts, service accounts, Google groups, and
                   domains (such as G Suite). A role is a named list of
                   permissions (defined by IAM or configured by users).
                   A binding can optionally specify a condition, which
                   is a logic expression that further constrains the
                   role binding based on attributes about the request
                   and/or target resource.

                   **JSON Example**

                      {
                         "bindings": [
                            {
                               "role":
                               "roles/resourcemanager.organizationAdmin",
                               "members": [ "user:mike@example.com",
                               "group:admins@example.com",
                               "domain:google.com",
                               "serviceAccount:my-project-id@appspot.gserviceaccount.com"
                               ]

                            }, { "role":
                            "roles/resourcemanager.organizationViewer",
                            "members": ["user:eve@example.com"],
                            "condition": { "title": "expirable access",
                            "description": "Does not grant access after
                            Sep 2020", "expression": "request.time <
                            timestamp('2020-10-01T00:00:00.000Z')", } }

                         ]

                      }

                   **YAML Example**

                      bindings: - members: - user:\ mike@example.com -
                      group:\ admins@example.com - domain:google.com -
                      serviceAccount:\ my-project-id@appspot.gserviceaccount.com
                      role: roles/resourcemanager.organizationAdmin -
                      members: - user:\ eve@example.com role:
                      roles/resourcemanager.organizationViewer
                      condition: title: expirable access description:
                      Does not grant access after Sep 2020 expression:
                      request.time <
                      timestamp('2020-10-01T00:00:00.000Z')

                   For a description of IAM and its features, see the
                   [IAM developer's
                   guide](\ https://cloud.google.com/iam/docs).

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.SetIamPolicyRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.SetIamPolicyRequest):
            request = storage.SetIamPolicyRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.set_bucket_iam_policy]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def test_bucket_iam_permissions(self,
            request: storage.TestIamPermissionsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam_policy.TestIamPermissionsResponse:
        r"""Tests a set of permissions on the given bucket to see
        which, if any, are held by the caller.

        Args:
            request (google.storage_v1.types.TestIamPermissionsRequest):
                The request object. A wrapper around the IAM test iam
                permissions request to support our
                common_request_params.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.v1.iam_policy_pb2.TestIamPermissionsResponse:
                Response message for TestIamPermissions method.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.TestIamPermissionsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.TestIamPermissionsRequest):
            request = storage.TestIamPermissionsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.test_bucket_iam_permissions]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def patch_bucket(self,
            request: storage.PatchBucketRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.Bucket:
        r"""Updates a bucket. Changes to the bucket will be
        readable immediately after writing, but configuration
        changes may take time to propagate.

        Args:
            request (google.storage_v1.types.PatchBucketRequest):
                The request object. Request for PatchBucket method.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.Bucket:
                A bucket.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.PatchBucketRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.PatchBucketRequest):
            request = storage.PatchBucketRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.patch_bucket]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def update_bucket(self,
            request: storage.UpdateBucketRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.Bucket:
        r"""Updates a bucket. Equivalent to PatchBucket, but
        always replaces all mutatable fields of the bucket with
        new values, reverting all unspecified fields to their
        default values.
        Like PatchBucket, Changes to the bucket will be readable
        immediately after writing, but configuration changes may
        take time to propagate.

        Args:
            request (google.storage_v1.types.UpdateBucketRequest):
                The request object. Request for UpdateBucket method.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.Bucket:
                A bucket.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.UpdateBucketRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.UpdateBucketRequest):
            request = storage.UpdateBucketRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_bucket]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def stop_channel(self,
            request: storage.StopChannelRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Halts "Object Change Notification" push messagages.
        See https://cloud.google.com/storage/docs/object-change-
        notification Note: this is not related to the newer
        "Notifications" resource, which are stopped using
        DeleteNotification.

        Args:
            request (google.storage_v1.types.StopChannelRequest):
                The request object. Request message for StopChannel.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.StopChannelRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.StopChannelRequest):
            request = storage.StopChannelRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.stop_channel]

        # Send the request.
        rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    def delete_default_object_access_control(self,
            request: storage.DeleteDefaultObjectAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Permanently deletes the default object ACL entry for
        the specified entity on the specified bucket.

        Args:
            request (google.storage_v1.types.DeleteDefaultObjectAccessControlRequest):
                The request object. Request message for
                DeleteDefaultObjectAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.DeleteDefaultObjectAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.DeleteDefaultObjectAccessControlRequest):
            request = storage.DeleteDefaultObjectAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete_default_object_access_control]

        # Send the request.
        rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    def get_default_object_access_control(self,
            request: storage.GetDefaultObjectAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.ObjectAccessControl:
        r"""Returns the default object ACL entry for the
        specified entity on the specified bucket.

        Args:
            request (google.storage_v1.types.GetDefaultObjectAccessControlRequest):
                The request object. Request message for
                GetDefaultObjectAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.ObjectAccessControl:
                An access-control entry.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.GetDefaultObjectAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.GetDefaultObjectAccessControlRequest):
            request = storage.GetDefaultObjectAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_default_object_access_control]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def insert_default_object_access_control(self,
            request: storage.InsertDefaultObjectAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.ObjectAccessControl:
        r"""Creates a new default object ACL entry on the
        specified bucket.

        Args:
            request (google.storage_v1.types.InsertDefaultObjectAccessControlRequest):
                The request object. Request message for
                InsertDefaultObjectAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.ObjectAccessControl:
                An access-control entry.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.InsertDefaultObjectAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.InsertDefaultObjectAccessControlRequest):
            request = storage.InsertDefaultObjectAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.insert_default_object_access_control]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def list_default_object_access_controls(self,
            request: storage.ListDefaultObjectAccessControlsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.ListObjectAccessControlsResponse:
        r"""Retrieves default object ACL entries on the specified
        bucket.

        Args:
            request (google.storage_v1.types.ListDefaultObjectAccessControlsRequest):
                The request object. Request message for
                ListDefaultObjectAccessControls.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.ListObjectAccessControlsResponse:
                The result of a call to
                ObjectAccessControls.ListObjectAccessControls.

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.ListDefaultObjectAccessControlsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.ListDefaultObjectAccessControlsRequest):
            request = storage.ListDefaultObjectAccessControlsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_default_object_access_controls]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def patch_default_object_access_control(self,
            request: storage.PatchDefaultObjectAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.ObjectAccessControl:
        r"""Updates a default object ACL entry on the specified
        bucket.

        Args:
            request (google.storage_v1.types.PatchDefaultObjectAccessControlRequest):
                The request object. Request message for
                PatchDefaultObjectAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.ObjectAccessControl:
                An access-control entry.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.PatchDefaultObjectAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.PatchDefaultObjectAccessControlRequest):
            request = storage.PatchDefaultObjectAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.patch_default_object_access_control]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def update_default_object_access_control(self,
            request: storage.UpdateDefaultObjectAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.ObjectAccessControl:
        r"""Updates a default object ACL entry on the specified
        bucket. Equivalent to PatchDefaultObjectAccessControl,
        but modifies all unspecified fields to their default
        values.

        Args:
            request (google.storage_v1.types.UpdateDefaultObjectAccessControlRequest):
                The request object. Request message for
                UpdateDefaultObjectAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.ObjectAccessControl:
                An access-control entry.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.UpdateDefaultObjectAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.UpdateDefaultObjectAccessControlRequest):
            request = storage.UpdateDefaultObjectAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_default_object_access_control]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def delete_notification(self,
            request: storage.DeleteNotificationRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Permanently deletes a notification subscription.
        Note: Older, "Object Change Notification" push
        subscriptions should be deleted using StopChannel
        instead.

        Args:
            request (google.storage_v1.types.DeleteNotificationRequest):
                The request object. Request message for
                DeleteNotification.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.DeleteNotificationRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.DeleteNotificationRequest):
            request = storage.DeleteNotificationRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete_notification]

        # Send the request.
        rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    def get_notification(self,
            request: storage.GetNotificationRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.Notification:
        r"""View a notification configuration.

        Args:
            request (google.storage_v1.types.GetNotificationRequest):
                The request object. Request message for GetNotification.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.Notification:
                A subscription to receive Google
                PubSub notifications.

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.GetNotificationRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.GetNotificationRequest):
            request = storage.GetNotificationRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_notification]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def insert_notification(self,
            request: storage.InsertNotificationRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.Notification:
        r"""Creates a notification subscription for a given
        bucket. These notifications, when triggered, publish
        messages to the specified Cloud Pub/Sub topics.
        See https://cloud.google.com/storage/docs/pubsub-
        notifications.

        Args:
            request (google.storage_v1.types.InsertNotificationRequest):
                The request object. Request message for
                InsertNotification.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.Notification:
                A subscription to receive Google
                PubSub notifications.

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.InsertNotificationRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.InsertNotificationRequest):
            request = storage.InsertNotificationRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.insert_notification]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def list_notifications(self,
            request: storage.ListNotificationsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.ListNotificationsResponse:
        r"""Retrieves a list of notification subscriptions for a
        given bucket.

        Args:
            request (google.storage_v1.types.ListNotificationsRequest):
                The request object. Request message for
                ListNotifications.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.ListNotificationsResponse:
                The result of a call to
                Notifications.ListNotifications

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.ListNotificationsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.ListNotificationsRequest):
            request = storage.ListNotificationsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_notifications]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def delete_object_access_control(self,
            request: storage.DeleteObjectAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Permanently deletes the ACL entry for the specified
        entity on the specified object.

        Args:
            request (google.storage_v1.types.DeleteObjectAccessControlRequest):
                The request object. Request message for
                DeleteObjectAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.DeleteObjectAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.DeleteObjectAccessControlRequest):
            request = storage.DeleteObjectAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete_object_access_control]

        # Send the request.
        rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    def get_object_access_control(self,
            request: storage.GetObjectAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.ObjectAccessControl:
        r"""Returns the ACL entry for the specified entity on the
        specified object.

        Args:
            request (google.storage_v1.types.GetObjectAccessControlRequest):
                The request object. Request message for
                GetObjectAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.ObjectAccessControl:
                An access-control entry.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.GetObjectAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.GetObjectAccessControlRequest):
            request = storage.GetObjectAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_object_access_control]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def insert_object_access_control(self,
            request: storage.InsertObjectAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.ObjectAccessControl:
        r"""Creates a new ACL entry on the specified object.

        Args:
            request (google.storage_v1.types.InsertObjectAccessControlRequest):
                The request object. Request message for
                InsertObjectAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.ObjectAccessControl:
                An access-control entry.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.InsertObjectAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.InsertObjectAccessControlRequest):
            request = storage.InsertObjectAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.insert_object_access_control]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def list_object_access_controls(self,
            request: storage.ListObjectAccessControlsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.ListObjectAccessControlsResponse:
        r"""Retrieves ACL entries on the specified object.

        Args:
            request (google.storage_v1.types.ListObjectAccessControlsRequest):
                The request object. Request message for
                ListObjectAccessControls.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.ListObjectAccessControlsResponse:
                The result of a call to
                ObjectAccessControls.ListObjectAccessControls.

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.ListObjectAccessControlsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.ListObjectAccessControlsRequest):
            request = storage.ListObjectAccessControlsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_object_access_controls]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def patch_object_access_control(self,
            request: storage.PatchObjectAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.ObjectAccessControl:
        r"""Patches an ACL entry on the specified object. Patch is similar
        to update, but only applies or appends the specified fields in
        the object_access_control object. Other fields are unaffected.

        Args:
            request (google.storage_v1.types.PatchObjectAccessControlRequest):
                The request object. Request message for
                PatchObjectAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.ObjectAccessControl:
                An access-control entry.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.PatchObjectAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.PatchObjectAccessControlRequest):
            request = storage.PatchObjectAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.patch_object_access_control]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def update_object_access_control(self,
            request: storage.UpdateObjectAccessControlRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.ObjectAccessControl:
        r"""Updates an ACL entry on the specified object.

        Args:
            request (google.storage_v1.types.UpdateObjectAccessControlRequest):
                The request object. Request message for
                UpdateObjectAccessControl.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.ObjectAccessControl:
                An access-control entry.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.UpdateObjectAccessControlRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.UpdateObjectAccessControlRequest):
            request = storage.UpdateObjectAccessControlRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_object_access_control]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def compose_object(self,
            request: storage.ComposeObjectRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.Object:
        r"""Concatenates a list of existing objects into a new
        object in the same bucket.

        Args:
            request (google.storage_v1.types.ComposeObjectRequest):
                The request object. Request message for ComposeObject.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.Object:
                An object.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.ComposeObjectRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.ComposeObjectRequest):
            request = storage.ComposeObjectRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.compose_object]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def copy_object(self,
            request: storage.CopyObjectRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.Object:
        r"""Copies a source object to a destination object.
        Optionally overrides metadata.

        Args:
            request (google.storage_v1.types.CopyObjectRequest):
                The request object. Request message for CopyObject.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.Object:
                An object.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.CopyObjectRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.CopyObjectRequest):
            request = storage.CopyObjectRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.copy_object]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def delete_object(self,
            request: storage.DeleteObjectRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Deletes an object and its metadata. Deletions are permanent if
        versioning is not enabled for the bucket, or if the
        ``generation`` parameter is used.

        Args:
            request (google.storage_v1.types.DeleteObjectRequest):
                The request object. Message for deleting an object.
                Either `bucket` and `object` *or* `upload_id` **must**
                be set (but not both).

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.DeleteObjectRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.DeleteObjectRequest):
            request = storage.DeleteObjectRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete_object]

        # Send the request.
        rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    def get_object(self,
            request: storage.GetObjectRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.Object:
        r"""Retrieves an object's metadata.

        Args:
            request (google.storage_v1.types.GetObjectRequest):
                The request object. Request message for GetObject.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.Object:
                An object.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.GetObjectRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.GetObjectRequest):
            request = storage.GetObjectRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_object]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def get_object_media(self,
            request: storage.GetObjectMediaRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> Iterable[storage.GetObjectMediaResponse]:
        r"""Reads an object's data.

        Args:
            request (google.storage_v1.types.GetObjectMediaRequest):
                The request object. Request message for GetObjectMedia.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            Iterable[google.storage_v1.types.GetObjectMediaResponse]:
                Response message for GetObject.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.GetObjectMediaRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.GetObjectMediaRequest):
            request = storage.GetObjectMediaRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_object_media]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def insert_object(self,
            requests: Iterator[storage.InsertObjectRequest] = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.Object:
        r"""Stores a new object and metadata.

        An object can be written either in a single message stream or in
        a resumable sequence of message streams. To write using a single
        stream, the client should include in the first message of the
        stream an ``InsertObjectSpec`` describing the destination
        bucket, object, and any preconditions. Additionally, the final
        message must set 'finish_write' to true, or else it is an error.

        For a resumable write, the client should instead call
        ``StartResumableWrite()`` and provide that method an
        ``InsertObjectSpec.`` They should then attach the returned
        ``upload_id`` to the first message of each following call to
        ``Insert``. If there is an error or the connection is broken
        during the resumable ``Insert()``, the client should check the
        status of the ``Insert()`` by calling ``QueryWriteStatus()`` and
        continue writing from the returned ``committed_size``. This may
        be less than the amount of data the client previously sent.

        The service will not view the object as complete until the
        client has sent an ``Insert`` with ``finish_write`` set to
        ``true``. Sending any requests on a stream after sending a
        request with ``finish_write`` set to ``true`` will cause an
        error. The client **should** check the ``Object`` it receives to
        determine how much data the service was able to commit and
        whether the service views the object as complete.

        Args:
            requests (Iterator[google.storage_v1.types.InsertObjectRequest]):
                The request object iterator. Message for writing an object.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.Object:
                An object.
        """

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.insert_object]

        # Send the request.
        response = rpc(
            requests,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def list_objects(self,
            request: storage.ListObjectsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListObjectsPager:
        r"""Retrieves a list of objects matching the criteria.

        Args:
            request (google.storage_v1.types.ListObjectsRequest):
                The request object. Request message for ListObjects.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.services.storage.pagers.ListObjectsPager:
                The result of a call to
                Objects.ListObjects
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.ListObjectsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.ListObjectsRequest):
            request = storage.ListObjectsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_objects]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__iter__` convenience method.
        response = pagers.ListObjectsPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def rewrite_object(self,
            request: storage.RewriteObjectRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage.RewriteResponse:
        r"""Rewrites a source object to a destination object.
        Optionally overrides metadata.

        Args:
            request (google.storage_v1.types.RewriteObjectRequest):
                The request object. Request message for RewriteObject.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.RewriteResponse:
                A rewrite response.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.RewriteObjectRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.RewriteObjectRequest):
            request = storage.RewriteObjectRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.rewrite_object]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def start_resumable_write(self,
            request: storage.StartResumableWriteRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage.StartResumableWriteResponse:
        r"""Starts a resumable write. How long the write
        operation remains valid, and what happens when the write
        operation becomes invalid, are service-dependent.

        Args:
            request (google.storage_v1.types.StartResumableWriteRequest):
                The request object. Request message StartResumableWrite.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.StartResumableWriteResponse:
                Response object for
                ByteStream.StartResumableWrite.

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.StartResumableWriteRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.StartResumableWriteRequest):
            request = storage.StartResumableWriteRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.start_resumable_write]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def query_write_status(self,
            request: storage.QueryWriteStatusRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage.QueryWriteStatusResponse:
        r"""Determines the ``committed_size`` for an object that is being
        written, which can then be used as the ``write_offset`` for the
        next ``Write()`` call.

        If the object does not exist (i.e., the object has been deleted,
        or the first ``Write()`` has not yet reached the service), this
        method returns the error ``NOT_FOUND``.

        The client **may** call ``QueryWriteStatus()`` at any time to
        determine how much data has been processed for this object. This
        is useful if the client is buffering data and needs to know
        which data can be safely evicted. For any sequence of
        ``QueryWriteStatus()`` calls for a given object name, the
        sequence of returned ``committed_size`` values will be
        non-decreasing.

        Args:
            request (google.storage_v1.types.QueryWriteStatusRequest):
                The request object. Request object for
                `ByteStream.QueryWriteStatus`.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.QueryWriteStatusResponse:
                Response object for ByteStream.QueryWriteStatus.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.QueryWriteStatusRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.QueryWriteStatusRequest):
            request = storage.QueryWriteStatusRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.query_write_status]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def patch_object(self,
            request: storage.PatchObjectRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.Object:
        r"""Updates an object's metadata.

        Args:
            request (google.storage_v1.types.PatchObjectRequest):
                The request object. Request message for PatchObject.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.Object:
                An object.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.PatchObjectRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.PatchObjectRequest):
            request = storage.PatchObjectRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.patch_object]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def update_object(self,
            request: storage.UpdateObjectRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.Object:
        r"""Updates an object's metadata. Equivalent to
        PatchObject, but always replaces all mutatable fields of
        the bucket with new values, reverting all unspecified
        fields to their default values.

        Args:
            request (google.storage_v1.types.UpdateObjectRequest):
                The request object. Request message for UpdateObject.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.Object:
                An object.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.UpdateObjectRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.UpdateObjectRequest):
            request = storage.UpdateObjectRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_object]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def get_object_iam_policy(self,
            request: storage.GetIamPolicyRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> gi_policy.Policy:
        r"""Gets the IAM policy for the specified object.

        Args:
            request (google.storage_v1.types.GetIamPolicyRequest):
                The request object. A wrapper around the IAM get policy
                request to support our common_request_params.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.v1.policy_pb2.Policy:
                Defines an Identity and Access Management (IAM) policy. It is used to
                   specify access control policies for Cloud Platform
                   resources.

                   A Policy is a collection of bindings. A binding binds
                   one or more members to a single role. Members can be
                   user accounts, service accounts, Google groups, and
                   domains (such as G Suite). A role is a named list of
                   permissions (defined by IAM or configured by users).
                   A binding can optionally specify a condition, which
                   is a logic expression that further constrains the
                   role binding based on attributes about the request
                   and/or target resource.

                   **JSON Example**

                      {
                         "bindings": [
                            {
                               "role":
                               "roles/resourcemanager.organizationAdmin",
                               "members": [ "user:mike@example.com",
                               "group:admins@example.com",
                               "domain:google.com",
                               "serviceAccount:my-project-id@appspot.gserviceaccount.com"
                               ]

                            }, { "role":
                            "roles/resourcemanager.organizationViewer",
                            "members": ["user:eve@example.com"],
                            "condition": { "title": "expirable access",
                            "description": "Does not grant access after
                            Sep 2020", "expression": "request.time <
                            timestamp('2020-10-01T00:00:00.000Z')", } }

                         ]

                      }

                   **YAML Example**

                      bindings: - members: - user:\ mike@example.com -
                      group:\ admins@example.com - domain:google.com -
                      serviceAccount:\ my-project-id@appspot.gserviceaccount.com
                      role: roles/resourcemanager.organizationAdmin -
                      members: - user:\ eve@example.com role:
                      roles/resourcemanager.organizationViewer
                      condition: title: expirable access description:
                      Does not grant access after Sep 2020 expression:
                      request.time <
                      timestamp('2020-10-01T00:00:00.000Z')

                   For a description of IAM and its features, see the
                   [IAM developer's
                   guide](\ https://cloud.google.com/iam/docs).

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.GetIamPolicyRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.GetIamPolicyRequest):
            request = storage.GetIamPolicyRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_object_iam_policy]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def set_object_iam_policy(self,
            request: storage.SetIamPolicyRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> gi_policy.Policy:
        r"""Updates an IAM policy for the specified object.

        Args:
            request (google.storage_v1.types.SetIamPolicyRequest):
                The request object. A wrapper around the IAM set policy
                request to support our common_request_params.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.v1.policy_pb2.Policy:
                Defines an Identity and Access Management (IAM) policy. It is used to
                   specify access control policies for Cloud Platform
                   resources.

                   A Policy is a collection of bindings. A binding binds
                   one or more members to a single role. Members can be
                   user accounts, service accounts, Google groups, and
                   domains (such as G Suite). A role is a named list of
                   permissions (defined by IAM or configured by users).
                   A binding can optionally specify a condition, which
                   is a logic expression that further constrains the
                   role binding based on attributes about the request
                   and/or target resource.

                   **JSON Example**

                      {
                         "bindings": [
                            {
                               "role":
                               "roles/resourcemanager.organizationAdmin",
                               "members": [ "user:mike@example.com",
                               "group:admins@example.com",
                               "domain:google.com",
                               "serviceAccount:my-project-id@appspot.gserviceaccount.com"
                               ]

                            }, { "role":
                            "roles/resourcemanager.organizationViewer",
                            "members": ["user:eve@example.com"],
                            "condition": { "title": "expirable access",
                            "description": "Does not grant access after
                            Sep 2020", "expression": "request.time <
                            timestamp('2020-10-01T00:00:00.000Z')", } }

                         ]

                      }

                   **YAML Example**

                      bindings: - members: - user:\ mike@example.com -
                      group:\ admins@example.com - domain:google.com -
                      serviceAccount:\ my-project-id@appspot.gserviceaccount.com
                      role: roles/resourcemanager.organizationAdmin -
                      members: - user:\ eve@example.com role:
                      roles/resourcemanager.organizationViewer
                      condition: title: expirable access description:
                      Does not grant access after Sep 2020 expression:
                      request.time <
                      timestamp('2020-10-01T00:00:00.000Z')

                   For a description of IAM and its features, see the
                   [IAM developer's
                   guide](\ https://cloud.google.com/iam/docs).

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.SetIamPolicyRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.SetIamPolicyRequest):
            request = storage.SetIamPolicyRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.set_object_iam_policy]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def test_object_iam_permissions(self,
            request: storage.TestIamPermissionsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam_policy.TestIamPermissionsResponse:
        r"""Tests a set of permissions on the given object to see
        which, if any, are held by the caller.

        Args:
            request (google.storage_v1.types.TestIamPermissionsRequest):
                The request object. A wrapper around the IAM test iam
                permissions request to support our
                common_request_params.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.v1.iam_policy_pb2.TestIamPermissionsResponse:
                Response message for TestIamPermissions method.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.TestIamPermissionsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.TestIamPermissionsRequest):
            request = storage.TestIamPermissionsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.test_object_iam_permissions]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def watch_all_objects(self,
            request: storage.WatchAllObjectsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.Channel:
        r"""Watch for changes on all objects in a bucket.

        Args:
            request (google.storage_v1.types.WatchAllObjectsRequest):
                The request object. Request message for WatchAllObjects.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.Channel:
                An notification channel used to watch
                for resource changes.

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.WatchAllObjectsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.WatchAllObjectsRequest):
            request = storage.WatchAllObjectsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.watch_all_objects]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def get_service_account(self,
            request: storage.GetProjectServiceAccountRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.ServiceAccount:
        r"""Retrieves the name of a project's Google Cloud
        Storage service account.

        Args:
            request (google.storage_v1.types.GetProjectServiceAccountRequest):
                The request object. Request message for
                GetProjectServiceAccount.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.ServiceAccount:
                A subscription to receive Google
                PubSub notifications.

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.GetProjectServiceAccountRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.GetProjectServiceAccountRequest):
            request = storage.GetProjectServiceAccountRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_service_account]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def create_hmac_key(self,
            request: storage.CreateHmacKeyRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage.CreateHmacKeyResponse:
        r"""Creates a new HMAC key for the given service account.

        Args:
            request (google.storage_v1.types.CreateHmacKeyRequest):
                The request object.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.CreateHmacKeyResponse:
                Create hmac response.  The only time
                the secret for an HMAC will be returned.

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.CreateHmacKeyRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.CreateHmacKeyRequest):
            request = storage.CreateHmacKeyRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.create_hmac_key]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def delete_hmac_key(self,
            request: storage.DeleteHmacKeyRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Deletes a given HMAC key.  Key must be in an INACTIVE
        state.

        Args:
            request (google.storage_v1.types.DeleteHmacKeyRequest):
                The request object. Request object to delete a given
                HMAC key.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.DeleteHmacKeyRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.DeleteHmacKeyRequest):
            request = storage.DeleteHmacKeyRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete_hmac_key]

        # Send the request.
        rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    def get_hmac_key(self,
            request: storage.GetHmacKeyRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.HmacKeyMetadata:
        r"""Gets an existing HMAC key metadata for the given id.

        Args:
            request (google.storage_v1.types.GetHmacKeyRequest):
                The request object. Request object to get metadata on a
                given HMAC key.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.HmacKeyMetadata:
                Hmac Key Metadata, which includes all
                information other than the secret.

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.GetHmacKeyRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.GetHmacKeyRequest):
            request = storage.GetHmacKeyRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_hmac_key]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def list_hmac_keys(self,
            request: storage.ListHmacKeysRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListHmacKeysPager:
        r"""Lists HMAC keys under a given project with the
        additional filters provided.

        Args:
            request (google.storage_v1.types.ListHmacKeysRequest):
                The request object. Request to fetch a list of HMAC keys
                under a given project.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.services.storage.pagers.ListHmacKeysPager:
                Hmac key list response with next page
                information.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.ListHmacKeysRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.ListHmacKeysRequest):
            request = storage.ListHmacKeysRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_hmac_keys]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__iter__` convenience method.
        response = pagers.ListHmacKeysPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def update_hmac_key(self,
            request: storage.UpdateHmacKeyRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> storage_resources.HmacKeyMetadata:
        r"""Updates a given HMAC key state between ACTIVE and
        INACTIVE.

        Args:
            request (google.storage_v1.types.UpdateHmacKeyRequest):
                The request object. Request object to update an HMAC key
                state.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.storage_v1.types.HmacKeyMetadata:
                Hmac Key Metadata, which includes all
                information other than the secret.

        """
        # Create or coerce a protobuf request object.

        # Minor optimization to avoid making a copy if the user passes
        # in a storage.UpdateHmacKeyRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, storage.UpdateHmacKeyRequest):
            request = storage.UpdateHmacKeyRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_hmac_key]

        # Send the request.
        response = rpc(
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
            'google-storage',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    'StorageClient',
)
