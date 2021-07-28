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
from typing import Callable, Dict, Optional, Sequence, Tuple, Type, Union
import pkg_resources

from google.api_core import client_options as client_options_lib  # type: ignore
from google.api_core import exceptions as core_exceptions         # type: ignore
from google.api_core import gapic_v1                              # type: ignore
from google.api_core import retry as retries                      # type: ignore
from google.auth import credentials as ga_credentials             # type: ignore
from google.auth.transport import mtls                            # type: ignore
from google.auth.transport.grpc import SslCredentials             # type: ignore
from google.auth.exceptions import MutualTLSChannelError          # type: ignore
from google.oauth2 import service_account                         # type: ignore

from google.api_core import operation  # type: ignore
from google.api_core import operation_async  # type: ignore
from google.identity.accesscontextmanager_v1.services.access_context_manager import pagers
from google.identity.accesscontextmanager_v1.types import access_context_manager
from google.identity.accesscontextmanager_v1.types import access_level
from google.identity.accesscontextmanager_v1.types import access_level as gia_access_level
from google.identity.accesscontextmanager_v1.types import access_policy
from google.identity.accesscontextmanager_v1.types import gcp_user_access_binding
from google.identity.accesscontextmanager_v1.types import gcp_user_access_binding as gia_gcp_user_access_binding
from google.identity.accesscontextmanager_v1.types import service_perimeter
from google.identity.accesscontextmanager_v1.types import service_perimeter as gia_service_perimeter
from google.protobuf import empty_pb2  # type: ignore
from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from .transports.base import AccessContextManagerTransport, DEFAULT_CLIENT_INFO
from .transports.grpc import AccessContextManagerGrpcTransport
from .transports.grpc_asyncio import AccessContextManagerGrpcAsyncIOTransport


class AccessContextManagerClientMeta(type):
    """Metaclass for the AccessContextManager client.

    This provides class-level methods for building and retrieving
    support objects (e.g. transport) without polluting the client instance
    objects.
    """
    _transport_registry = OrderedDict()  # type: Dict[str, Type[AccessContextManagerTransport]]
    _transport_registry["grpc"] = AccessContextManagerGrpcTransport
    _transport_registry["grpc_asyncio"] = AccessContextManagerGrpcAsyncIOTransport

    def get_transport_class(cls,
            label: str = None,
        ) -> Type[AccessContextManagerTransport]:
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


class AccessContextManagerClient(metaclass=AccessContextManagerClientMeta):
    """API for setting [Access Levels]
    [google.identity.accesscontextmanager.v1.AccessLevel] and [Service
    Perimeters]
    [google.identity.accesscontextmanager.v1.ServicePerimeter] for
    Google Cloud Projects. Each organization has one [AccessPolicy]
    [google.identity.accesscontextmanager.v1.AccessPolicy] containing
    the [Access Levels]
    [google.identity.accesscontextmanager.v1.AccessLevel] and [Service
    Perimeters]
    [google.identity.accesscontextmanager.v1.ServicePerimeter]. This
    [AccessPolicy]
    [google.identity.accesscontextmanager.v1.AccessPolicy] is applicable
    to all resources in the organization. AccessPolicies
    """

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

    DEFAULT_ENDPOINT = "accesscontextmanager.googleapis.com"
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
            AccessContextManagerClient: The constructed client.
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
            AccessContextManagerClient: The constructed client.
        """
        credentials = service_account.Credentials.from_service_account_file(
            filename)
        kwargs["credentials"] = credentials
        return cls(*args, **kwargs)

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> AccessContextManagerTransport:
        """Returns the transport used by the client instance.

        Returns:
            AccessContextManagerTransport: The transport used by the client
                instance.
        """
        return self._transport

    @staticmethod
    def access_level_path(access_policy: str,access_level: str,) -> str:
        """Returns a fully-qualified access_level string."""
        return "accessPolicies/{access_policy}/accessLevels/{access_level}".format(access_policy=access_policy, access_level=access_level, )

    @staticmethod
    def parse_access_level_path(path: str) -> Dict[str,str]:
        """Parses a access_level path into its component segments."""
        m = re.match(r"^accessPolicies/(?P<access_policy>.+?)/accessLevels/(?P<access_level>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def access_policy_path(access_policy: str,) -> str:
        """Returns a fully-qualified access_policy string."""
        return "accessPolicies/{access_policy}".format(access_policy=access_policy, )

    @staticmethod
    def parse_access_policy_path(path: str) -> Dict[str,str]:
        """Parses a access_policy path into its component segments."""
        m = re.match(r"^accessPolicies/(?P<access_policy>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def gcp_user_access_binding_path(organization: str,gcp_user_access_binding: str,) -> str:
        """Returns a fully-qualified gcp_user_access_binding string."""
        return "organizations/{organization}/gcpUserAccessBindings/{gcp_user_access_binding}".format(organization=organization, gcp_user_access_binding=gcp_user_access_binding, )

    @staticmethod
    def parse_gcp_user_access_binding_path(path: str) -> Dict[str,str]:
        """Parses a gcp_user_access_binding path into its component segments."""
        m = re.match(r"^organizations/(?P<organization>.+?)/gcpUserAccessBindings/(?P<gcp_user_access_binding>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def service_perimeter_path(access_policy: str,service_perimeter: str,) -> str:
        """Returns a fully-qualified service_perimeter string."""
        return "accessPolicies/{access_policy}/servicePerimeters/{service_perimeter}".format(access_policy=access_policy, service_perimeter=service_perimeter, )

    @staticmethod
    def parse_service_perimeter_path(path: str) -> Dict[str,str]:
        """Parses a service_perimeter path into its component segments."""
        m = re.match(r"^accessPolicies/(?P<access_policy>.+?)/servicePerimeters/(?P<service_perimeter>.+?)$", path)
        return m.groupdict() if m else {}

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
            transport: Union[str, AccessContextManagerTransport, None] = None,
            client_options: Optional[client_options_lib.ClientOptions] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the access context manager client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, AccessContextManagerTransport]): The
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
        if isinstance(transport, AccessContextManagerTransport):
            # transport is a AccessContextManagerTransport instance.
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
                always_use_jwt_access=(
                    Transport == type(self).get_transport_class("grpc")
                    or Transport == type(self).get_transport_class("grpc_asyncio")
                ),
            )

    def list_access_policies(self,
            request: access_context_manager.ListAccessPoliciesRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListAccessPoliciesPager:
        r"""List all [AccessPolicies]
        [google.identity.accesscontextmanager.v1.AccessPolicy] under a
        container.

        Args:
            request (google.identity.accesscontextmanager_v1.types.ListAccessPoliciesRequest):
                The request object. A request to list all
                `AccessPolicies` for a container.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.services.access_context_manager.pagers.ListAccessPoliciesPager:
                A response to ListAccessPoliciesRequest.

                Iterating over this object will yield results and
                resolve additional pages automatically.

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.ListAccessPoliciesRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.ListAccessPoliciesRequest):
            request = access_context_manager.ListAccessPoliciesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_access_policies]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__iter__` convenience method.
        response = pagers.ListAccessPoliciesPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def get_access_policy(self,
            request: access_context_manager.GetAccessPolicyRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> access_policy.AccessPolicy:
        r"""Get an [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] by name.

        Args:
            request (google.identity.accesscontextmanager_v1.types.GetAccessPolicyRequest):
                The request object. A request to get a particular
                `AccessPolicy`.
            name (str):
                Required. Resource name for the access policy to get.

                Format ``accessPolicies/{policy_id}``

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.types.AccessPolicy:
                AccessPolicy is a container for AccessLevels (which define the necessary
                   attributes to use Google Cloud services) and
                   ServicePerimeters (which define regions of services
                   able to freely pass data within a perimeter). An
                   access policy is globally visible within an
                   organization, and the restrictions it specifies apply
                   to all projects within an organization.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.GetAccessPolicyRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.GetAccessPolicyRequest):
            request = access_context_manager.GetAccessPolicyRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if name is not None:
                request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_access_policy]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def create_access_policy(self,
            request: access_policy.AccessPolicy = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Create an ``AccessPolicy``. Fails if this organization already
        has a ``AccessPolicy``. The longrunning Operation will have a
        successful status once the ``AccessPolicy`` has propagated to
        long-lasting storage. Syntactic and basic semantic errors will
        be returned in ``metadata`` as a BadRequest proto.

        Args:
            request (google.identity.accesscontextmanager_v1.types.AccessPolicy):
                The request object. `AccessPolicy` is a container for
                `AccessLevels` (which define the necessary attributes to
                use Google Cloud services) and `ServicePerimeters`
                (which define regions of services able to freely pass
                data within a perimeter). An access policy is globally
                visible within an organization, and the restrictions it
                specifies apply to all projects within an organization.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.AccessPolicy` AccessPolicy is a container for AccessLevels (which define the necessary
                   attributes to use Google Cloud services) and
                   ServicePerimeters (which define regions of services
                   able to freely pass data within a perimeter). An
                   access policy is globally visible within an
                   organization, and the restrictions it specifies apply
                   to all projects within an organization.

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a access_policy.AccessPolicy.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_policy.AccessPolicy):
            request = access_policy.AccessPolicy(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.create_access_policy]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            access_policy.AccessPolicy,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    def update_access_policy(self,
            request: access_context_manager.UpdateAccessPolicyRequest = None,
            *,
            policy: access_policy.AccessPolicy = None,
            update_mask: field_mask_pb2.FieldMask = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Update an [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy]. The
        longrunning Operation from this RPC will have a successful
        status once the changes to the [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] have
        propagated to long-lasting storage. Syntactic and basic semantic
        errors will be returned in ``metadata`` as a BadRequest proto.

        Args:
            request (google.identity.accesscontextmanager_v1.types.UpdateAccessPolicyRequest):
                The request object. A request to update an
                `AccessPolicy`.
            policy (google.identity.accesscontextmanager_v1.types.AccessPolicy):
                Required. The updated AccessPolicy.
                This corresponds to the ``policy`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            update_mask (google.protobuf.field_mask_pb2.FieldMask):
                Required. Mask to control which
                fields get updated. Must be non-empty.

                This corresponds to the ``update_mask`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.AccessPolicy` AccessPolicy is a container for AccessLevels (which define the necessary
                   attributes to use Google Cloud services) and
                   ServicePerimeters (which define regions of services
                   able to freely pass data within a perimeter). An
                   access policy is globally visible within an
                   organization, and the restrictions it specifies apply
                   to all projects within an organization.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([policy, update_mask])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.UpdateAccessPolicyRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.UpdateAccessPolicyRequest):
            request = access_context_manager.UpdateAccessPolicyRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if policy is not None:
                request.policy = policy
            if update_mask is not None:
                request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_access_policy]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("policy.name", request.policy.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            access_policy.AccessPolicy,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    def delete_access_policy(self,
            request: access_context_manager.DeleteAccessPolicyRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Delete an [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] by
        resource name. The longrunning Operation will have a successful
        status once the [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] has been
        removed from long-lasting storage.

        Args:
            request (google.identity.accesscontextmanager_v1.types.DeleteAccessPolicyRequest):
                The request object. A request to delete an
                `AccessPolicy`.
            name (str):
                Required. Resource name for the access policy to delete.

                Format ``accessPolicies/{policy_id}``

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.protobuf.empty_pb2.Empty` A generic empty message that you can re-use to avoid defining duplicated
                   empty messages in your APIs. A typical example is to
                   use it as the request or the response type of an API
                   method. For instance:

                      service Foo {
                         rpc Bar(google.protobuf.Empty) returns
                         (google.protobuf.Empty);

                      }

                   The JSON representation for Empty is empty JSON
                   object {}.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.DeleteAccessPolicyRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.DeleteAccessPolicyRequest):
            request = access_context_manager.DeleteAccessPolicyRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if name is not None:
                request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete_access_policy]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    def list_access_levels(self,
            request: access_context_manager.ListAccessLevelsRequest = None,
            *,
            parent: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListAccessLevelsPager:
        r"""List all [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] for an
        access policy.

        Args:
            request (google.identity.accesscontextmanager_v1.types.ListAccessLevelsRequest):
                The request object. A request to list all `AccessLevels`
                in an `AccessPolicy`.
            parent (str):
                Required. Resource name for the access policy to list
                [Access Levels]
                [google.identity.accesscontextmanager.v1.AccessLevel]
                from.

                Format: ``accessPolicies/{policy_id}``

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.services.access_context_manager.pagers.ListAccessLevelsPager:
                A response to ListAccessLevelsRequest.

                Iterating over this object will yield results and
                resolve additional pages automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.ListAccessLevelsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.ListAccessLevelsRequest):
            request = access_context_manager.ListAccessLevelsRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if parent is not None:
                request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_access_levels]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__iter__` convenience method.
        response = pagers.ListAccessLevelsPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def get_access_level(self,
            request: access_context_manager.GetAccessLevelRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> access_level.AccessLevel:
        r"""Get an [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] by
        resource name.

        Args:
            request (google.identity.accesscontextmanager_v1.types.GetAccessLevelRequest):
                The request object. A request to get a particular
                `AccessLevel`.
            name (str):
                Required. Resource name for the [Access Level]
                [google.identity.accesscontextmanager.v1.AccessLevel].

                Format:
                ``accessPolicies/{policy_id}/accessLevels/{access_level_id}``

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.types.AccessLevel:
                An AccessLevel is a label that can be applied to requests to Google Cloud
                   services, along with a list of requirements necessary
                   for the label to be applied.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.GetAccessLevelRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.GetAccessLevelRequest):
            request = access_context_manager.GetAccessLevelRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if name is not None:
                request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_access_level]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def create_access_level(self,
            request: access_context_manager.CreateAccessLevelRequest = None,
            *,
            parent: str = None,
            access_level: gia_access_level.AccessLevel = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Create an [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel]. The
        longrunning operation from this RPC will have a successful
        status once the [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] has
        propagated to long-lasting storage. [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] containing
        errors will result in an error response for the first error
        encountered.

        Args:
            request (google.identity.accesscontextmanager_v1.types.CreateAccessLevelRequest):
                The request object. A request to create an
                `AccessLevel`.
            parent (str):
                Required. Resource name for the access policy which owns
                this [Access Level]
                [google.identity.accesscontextmanager.v1.AccessLevel].

                Format: ``accessPolicies/{policy_id}``

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            access_level (google.identity.accesscontextmanager_v1.types.AccessLevel):
                Required. The [Access Level]
                [google.identity.accesscontextmanager.v1.AccessLevel] to
                create. Syntactic correctness of the [Access Level]
                [google.identity.accesscontextmanager.v1.AccessLevel] is
                a precondition for creation.

                This corresponds to the ``access_level`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.AccessLevel` An AccessLevel is a label that can be applied to requests to Google Cloud
                   services, along with a list of requirements necessary
                   for the label to be applied.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent, access_level])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.CreateAccessLevelRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.CreateAccessLevelRequest):
            request = access_context_manager.CreateAccessLevelRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if parent is not None:
                request.parent = parent
            if access_level is not None:
                request.access_level = access_level

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.create_access_level]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            gia_access_level.AccessLevel,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    def update_access_level(self,
            request: access_context_manager.UpdateAccessLevelRequest = None,
            *,
            access_level: gia_access_level.AccessLevel = None,
            update_mask: field_mask_pb2.FieldMask = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Update an [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel]. The
        longrunning operation from this RPC will have a successful
        status once the changes to the [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] have
        propagated to long-lasting storage. [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] containing
        errors will result in an error response for the first error
        encountered.

        Args:
            request (google.identity.accesscontextmanager_v1.types.UpdateAccessLevelRequest):
                The request object. A request to update an
                `AccessLevel`.
            access_level (google.identity.accesscontextmanager_v1.types.AccessLevel):
                Required. The updated [Access Level]
                [google.identity.accesscontextmanager.v1.AccessLevel].
                Syntactic correctness of the [Access Level]
                [google.identity.accesscontextmanager.v1.AccessLevel] is
                a precondition for creation.

                This corresponds to the ``access_level`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            update_mask (google.protobuf.field_mask_pb2.FieldMask):
                Required. Mask to control which
                fields get updated. Must be non-empty.

                This corresponds to the ``update_mask`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.AccessLevel` An AccessLevel is a label that can be applied to requests to Google Cloud
                   services, along with a list of requirements necessary
                   for the label to be applied.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([access_level, update_mask])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.UpdateAccessLevelRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.UpdateAccessLevelRequest):
            request = access_context_manager.UpdateAccessLevelRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if access_level is not None:
                request.access_level = access_level
            if update_mask is not None:
                request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_access_level]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("access_level.name", request.access_level.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            gia_access_level.AccessLevel,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    def delete_access_level(self,
            request: access_context_manager.DeleteAccessLevelRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Delete an [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] by
        resource name. The longrunning operation from this RPC will have
        a successful status once the [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] has been
        removed from long-lasting storage.

        Args:
            request (google.identity.accesscontextmanager_v1.types.DeleteAccessLevelRequest):
                The request object. A request to delete an
                `AccessLevel`.
            name (str):
                Required. Resource name for the [Access Level]
                [google.identity.accesscontextmanager.v1.AccessLevel].

                Format:
                ``accessPolicies/{policy_id}/accessLevels/{access_level_id}``

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.protobuf.empty_pb2.Empty` A generic empty message that you can re-use to avoid defining duplicated
                   empty messages in your APIs. A typical example is to
                   use it as the request or the response type of an API
                   method. For instance:

                      service Foo {
                         rpc Bar(google.protobuf.Empty) returns
                         (google.protobuf.Empty);

                      }

                   The JSON representation for Empty is empty JSON
                   object {}.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.DeleteAccessLevelRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.DeleteAccessLevelRequest):
            request = access_context_manager.DeleteAccessLevelRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if name is not None:
                request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete_access_level]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    def replace_access_levels(self,
            request: access_context_manager.ReplaceAccessLevelsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Replace all existing [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] in an
        [Access Policy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] with the
        [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] provided.
        This is done atomically. The longrunning operation from this RPC
        will have a successful status once all replacements have
        propagated to long-lasting storage. Replacements containing
        errors will result in an error response for the first error
        encountered. Replacement will be cancelled on error, existing
        [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] will not
        be affected. Operation.response field will contain
        ReplaceAccessLevelsResponse. Removing [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] contained
        in existing [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] will
        result in error.

        Args:
            request (google.identity.accesscontextmanager_v1.types.ReplaceAccessLevelsRequest):
                The request object. A request to replace all existing
                Access Levels in an Access Policy with the Access Levels
                provided. This is done atomically.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.ReplaceAccessLevelsResponse` A response to ReplaceAccessLevelsRequest. This will be put inside of
                   Operation.response field.

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.ReplaceAccessLevelsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.ReplaceAccessLevelsRequest):
            request = access_context_manager.ReplaceAccessLevelsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.replace_access_levels]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            access_context_manager.ReplaceAccessLevelsResponse,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    def list_service_perimeters(self,
            request: access_context_manager.ListServicePerimetersRequest = None,
            *,
            parent: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListServicePerimetersPager:
        r"""List all [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] for
        an access policy.

        Args:
            request (google.identity.accesscontextmanager_v1.types.ListServicePerimetersRequest):
                The request object. A request to list all
                `ServicePerimeters` in an `AccessPolicy`.
            parent (str):
                Required. Resource name for the access policy to list
                [Service Perimeters]
                [google.identity.accesscontextmanager.v1.ServicePerimeter]
                from.

                Format: ``accessPolicies/{policy_id}``

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.services.access_context_manager.pagers.ListServicePerimetersPager:
                A response to ListServicePerimetersRequest.

                Iterating over this object will yield results and
                resolve additional pages automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.ListServicePerimetersRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.ListServicePerimetersRequest):
            request = access_context_manager.ListServicePerimetersRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if parent is not None:
                request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_service_perimeters]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__iter__` convenience method.
        response = pagers.ListServicePerimetersPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def get_service_perimeter(self,
            request: access_context_manager.GetServicePerimeterRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> service_perimeter.ServicePerimeter:
        r"""Get a [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] by
        resource name.

        Args:
            request (google.identity.accesscontextmanager_v1.types.GetServicePerimeterRequest):
                The request object. A request to get a particular
                `ServicePerimeter`.
            name (str):
                Required. Resource name for the [Service Perimeter]
                [google.identity.accesscontextmanager.v1.ServicePerimeter].

                Format:
                ``accessPolicies/{policy_id}/servicePerimeters/{service_perimeters_id}``

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.types.ServicePerimeter:
                ServicePerimeter describes a set of Google Cloud resources which can freely
                   import and export data amongst themselves, but not
                   export outside of the ServicePerimeter. If a request
                   with a source within this ServicePerimeter has a
                   target outside of the ServicePerimeter, the request
                   will be blocked. Otherwise the request is allowed.
                   There are two types of Service Perimeter -Regular and
                   Bridge. Regular Service Perimeters cannot overlap, a
                   single Google Cloud project can only belong to a
                   single regular Service Perimeter. Service Perimeter
                   Bridges can contain only Google Cloud projects as
                   members, a single Google Cloud project may belong to
                   multiple Service Perimeter Bridges.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.GetServicePerimeterRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.GetServicePerimeterRequest):
            request = access_context_manager.GetServicePerimeterRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if name is not None:
                request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_service_perimeter]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def create_service_perimeter(self,
            request: access_context_manager.CreateServicePerimeterRequest = None,
            *,
            parent: str = None,
            service_perimeter: gia_service_perimeter.ServicePerimeter = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Create a [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        longrunning operation from this RPC will have a successful
        status once the [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] has
        propagated to long-lasting storage. [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]
        containing errors will result in an error response for the first
        error encountered.

        Args:
            request (google.identity.accesscontextmanager_v1.types.CreateServicePerimeterRequest):
                The request object. A request to create a
                `ServicePerimeter`.
            parent (str):
                Required. Resource name for the access policy which owns
                this [Service Perimeter]
                [google.identity.accesscontextmanager.v1.ServicePerimeter].

                Format: ``accessPolicies/{policy_id}``

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            service_perimeter (google.identity.accesscontextmanager_v1.types.ServicePerimeter):
                Required. The [Service Perimeter]
                [google.identity.accesscontextmanager.v1.ServicePerimeter]
                to create. Syntactic correctness of the [Service
                Perimeter]
                [google.identity.accesscontextmanager.v1.ServicePerimeter]
                is a precondition for creation.

                This corresponds to the ``service_perimeter`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.ServicePerimeter` ServicePerimeter describes a set of Google Cloud resources which can freely
                   import and export data amongst themselves, but not
                   export outside of the ServicePerimeter. If a request
                   with a source within this ServicePerimeter has a
                   target outside of the ServicePerimeter, the request
                   will be blocked. Otherwise the request is allowed.
                   There are two types of Service Perimeter -Regular and
                   Bridge. Regular Service Perimeters cannot overlap, a
                   single Google Cloud project can only belong to a
                   single regular Service Perimeter. Service Perimeter
                   Bridges can contain only Google Cloud projects as
                   members, a single Google Cloud project may belong to
                   multiple Service Perimeter Bridges.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent, service_perimeter])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.CreateServicePerimeterRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.CreateServicePerimeterRequest):
            request = access_context_manager.CreateServicePerimeterRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if parent is not None:
                request.parent = parent
            if service_perimeter is not None:
                request.service_perimeter = service_perimeter

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.create_service_perimeter]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            gia_service_perimeter.ServicePerimeter,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    def update_service_perimeter(self,
            request: access_context_manager.UpdateServicePerimeterRequest = None,
            *,
            service_perimeter: gia_service_perimeter.ServicePerimeter = None,
            update_mask: field_mask_pb2.FieldMask = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Update a [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        longrunning operation from this RPC will have a successful
        status once the changes to the [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] have
        propagated to long-lasting storage. [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]
        containing errors will result in an error response for the first
        error encountered.

        Args:
            request (google.identity.accesscontextmanager_v1.types.UpdateServicePerimeterRequest):
                The request object. A request to update a
                `ServicePerimeter`.
            service_perimeter (google.identity.accesscontextmanager_v1.types.ServicePerimeter):
                Required. The updated ``ServicePerimeter``. Syntactic
                correctness of the ``ServicePerimeter`` is a
                precondition for creation.

                This corresponds to the ``service_perimeter`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            update_mask (google.protobuf.field_mask_pb2.FieldMask):
                Required. Mask to control which
                fields get updated. Must be non-empty.

                This corresponds to the ``update_mask`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.ServicePerimeter` ServicePerimeter describes a set of Google Cloud resources which can freely
                   import and export data amongst themselves, but not
                   export outside of the ServicePerimeter. If a request
                   with a source within this ServicePerimeter has a
                   target outside of the ServicePerimeter, the request
                   will be blocked. Otherwise the request is allowed.
                   There are two types of Service Perimeter -Regular and
                   Bridge. Regular Service Perimeters cannot overlap, a
                   single Google Cloud project can only belong to a
                   single regular Service Perimeter. Service Perimeter
                   Bridges can contain only Google Cloud projects as
                   members, a single Google Cloud project may belong to
                   multiple Service Perimeter Bridges.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([service_perimeter, update_mask])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.UpdateServicePerimeterRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.UpdateServicePerimeterRequest):
            request = access_context_manager.UpdateServicePerimeterRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if service_perimeter is not None:
                request.service_perimeter = service_perimeter
            if update_mask is not None:
                request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_service_perimeter]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("service_perimeter.name", request.service_perimeter.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            gia_service_perimeter.ServicePerimeter,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    def delete_service_perimeter(self,
            request: access_context_manager.DeleteServicePerimeterRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Delete a [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] by
        resource name. The longrunning operation from this RPC will have
        a successful status once the [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] has
        been removed from long-lasting storage.

        Args:
            request (google.identity.accesscontextmanager_v1.types.DeleteServicePerimeterRequest):
                The request object. A request to delete a
                `ServicePerimeter`.
            name (str):
                Required. Resource name for the [Service Perimeter]
                [google.identity.accesscontextmanager.v1.ServicePerimeter].

                Format:
                ``accessPolicies/{policy_id}/servicePerimeters/{service_perimeter_id}``

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.protobuf.empty_pb2.Empty` A generic empty message that you can re-use to avoid defining duplicated
                   empty messages in your APIs. A typical example is to
                   use it as the request or the response type of an API
                   method. For instance:

                      service Foo {
                         rpc Bar(google.protobuf.Empty) returns
                         (google.protobuf.Empty);

                      }

                   The JSON representation for Empty is empty JSON
                   object {}.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.DeleteServicePerimeterRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.DeleteServicePerimeterRequest):
            request = access_context_manager.DeleteServicePerimeterRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if name is not None:
                request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete_service_perimeter]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    def replace_service_perimeters(self,
            request: access_context_manager.ReplaceServicePerimetersRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Replace all existing [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] in an
        [Access Policy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] with the
        [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]
        provided. This is done atomically. The longrunning operation
        from this RPC will have a successful status once all
        replacements have propagated to long-lasting storage.
        Replacements containing errors will result in an error response
        for the first error encountered. Replacement will be cancelled
        on error, existing [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] will
        not be affected. Operation.response field will contain
        ReplaceServicePerimetersResponse.

        Args:
            request (google.identity.accesscontextmanager_v1.types.ReplaceServicePerimetersRequest):
                The request object. A request to replace all existing
                Service Perimeters in an Access Policy with the Service
                Perimeters provided. This is done atomically.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.ReplaceServicePerimetersResponse` A response to ReplaceServicePerimetersRequest. This will be put inside of
                   Operation.response field.

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.ReplaceServicePerimetersRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.ReplaceServicePerimetersRequest):
            request = access_context_manager.ReplaceServicePerimetersRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.replace_service_perimeters]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            access_context_manager.ReplaceServicePerimetersResponse,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    def commit_service_perimeters(self,
            request: access_context_manager.CommitServicePerimetersRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Commit the dry-run spec for all the [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] in an
        [Access
        Policy][google.identity.accesscontextmanager.v1.AccessPolicy]. A
        commit operation on a Service Perimeter involves copying its
        ``spec`` field to that Service Perimeter's ``status`` field.
        Only [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] with
        ``use_explicit_dry_run_spec`` field set to true are affected by
        a commit operation. The longrunning operation from this RPC will
        have a successful status once the dry-run specs for all the
        [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] have
        been committed. If a commit fails, it will cause the longrunning
        operation to return an error response and the entire commit
        operation will be cancelled. When successful, Operation.response
        field will contain CommitServicePerimetersResponse. The
        ``dry_run`` and the ``spec`` fields will be cleared after a
        successful commit operation.

        Args:
            request (google.identity.accesscontextmanager_v1.types.CommitServicePerimetersRequest):
                The request object. A request to commit dry-run specs in
                all [Service Perimeters]
                [google.identity.accesscontextmanager.v1.ServicePerimeter]
                belonging to an [Access
                Policy][google.identity.accesscontextmanager.v1.AccessPolicy].
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.CommitServicePerimetersResponse` A response to CommitServicePerimetersRequest. This will be put inside of
                   Operation.response field.

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.CommitServicePerimetersRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.CommitServicePerimetersRequest):
            request = access_context_manager.CommitServicePerimetersRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.commit_service_perimeters]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            access_context_manager.CommitServicePerimetersResponse,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    def list_gcp_user_access_bindings(self,
            request: access_context_manager.ListGcpUserAccessBindingsRequest = None,
            *,
            parent: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListGcpUserAccessBindingsPager:
        r"""Lists all [GcpUserAccessBindings]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        for a Google Cloud organization.

        Args:
            request (google.identity.accesscontextmanager_v1.types.ListGcpUserAccessBindingsRequest):
                The request object. Request of
                [ListGcpUserAccessBindings]
                [google.identity.accesscontextmanager.v1.AccessContextManager.ListGcpUserAccessBindings].
            parent (str):
                Required. Example:
                "organizations/256"

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.services.access_context_manager.pagers.ListGcpUserAccessBindingsPager:
                Response of [ListGcpUserAccessBindings]
                   [google.identity.accesscontextmanager.v1.AccessContextManager.ListGcpUserAccessBindings].

                Iterating over this object will yield results and
                resolve additional pages automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.ListGcpUserAccessBindingsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.ListGcpUserAccessBindingsRequest):
            request = access_context_manager.ListGcpUserAccessBindingsRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if parent is not None:
                request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_gcp_user_access_bindings]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__iter__` convenience method.
        response = pagers.ListGcpUserAccessBindingsPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def get_gcp_user_access_binding(self,
            request: access_context_manager.GetGcpUserAccessBindingRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> gcp_user_access_binding.GcpUserAccessBinding:
        r"""Gets the [GcpUserAccessBinding]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        with the given name.

        Args:
            request (google.identity.accesscontextmanager_v1.types.GetGcpUserAccessBindingRequest):
                The request object. Request of [GetGcpUserAccessBinding]
                [google.identity.accesscontextmanager.v1.AccessContextManager.GetGcpUserAccessBinding].
            name (str):
                Required. Example:
                "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.types.GcpUserAccessBinding:
                Restricts access to Cloud Console and
                Google Cloud APIs for a set of users
                using Context-Aware Access.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.GetGcpUserAccessBindingRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.GetGcpUserAccessBindingRequest):
            request = access_context_manager.GetGcpUserAccessBindingRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if name is not None:
                request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_gcp_user_access_binding]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def create_gcp_user_access_binding(self,
            request: access_context_manager.CreateGcpUserAccessBindingRequest = None,
            *,
            parent: str = None,
            gcp_user_access_binding: gia_gcp_user_access_binding.GcpUserAccessBinding = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Creates a [GcpUserAccessBinding]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        If the client specifies a [name]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.name],
        the server will ignore it. Fails if a resource already exists
        with the same [group_key]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.group_key].
        Completion of this long-running operation does not necessarily
        signify that the new binding is deployed onto all affected
        users, which may take more time.

        Args:
            request (google.identity.accesscontextmanager_v1.types.CreateGcpUserAccessBindingRequest):
                The request object. Request of
                [CreateGcpUserAccessBinding]
                [google.identity.accesscontextmanager.v1.AccessContextManager.CreateGcpUserAccessBinding].
            parent (str):
                Required. Example:
                "organizations/256"

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            gcp_user_access_binding (google.identity.accesscontextmanager_v1.types.GcpUserAccessBinding):
                Required. [GcpUserAccessBinding]
                [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]

                This corresponds to the ``gcp_user_access_binding`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.GcpUserAccessBinding` Restricts access to Cloud Console and Google Cloud APIs for a set of users
                   using Context-Aware Access.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent, gcp_user_access_binding])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.CreateGcpUserAccessBindingRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.CreateGcpUserAccessBindingRequest):
            request = access_context_manager.CreateGcpUserAccessBindingRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if parent is not None:
                request.parent = parent
            if gcp_user_access_binding is not None:
                request.gcp_user_access_binding = gcp_user_access_binding

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.create_gcp_user_access_binding]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            gia_gcp_user_access_binding.GcpUserAccessBinding,
            metadata_type=access_context_manager.GcpUserAccessBindingOperationMetadata,
        )

        # Done; return the response.
        return response

    def update_gcp_user_access_binding(self,
            request: access_context_manager.UpdateGcpUserAccessBindingRequest = None,
            *,
            gcp_user_access_binding: gia_gcp_user_access_binding.GcpUserAccessBinding = None,
            update_mask: field_mask_pb2.FieldMask = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Updates a [GcpUserAccessBinding]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        Completion of this long-running operation does not necessarily
        signify that the changed binding is deployed onto all affected
        users, which may take more time.

        Args:
            request (google.identity.accesscontextmanager_v1.types.UpdateGcpUserAccessBindingRequest):
                The request object. Request of
                [UpdateGcpUserAccessBinding]
                [google.identity.accesscontextmanager.v1.AccessContextManager.UpdateGcpUserAccessBinding].
            gcp_user_access_binding (google.identity.accesscontextmanager_v1.types.GcpUserAccessBinding):
                Required. [GcpUserAccessBinding]
                [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]

                This corresponds to the ``gcp_user_access_binding`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            update_mask (google.protobuf.field_mask_pb2.FieldMask):
                Required. Only the fields specified in this mask are
                updated. Because name and group_key cannot be changed,
                update_mask is required and must always be:

                update_mask { paths: "access_levels" }

                This corresponds to the ``update_mask`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.GcpUserAccessBinding` Restricts access to Cloud Console and Google Cloud APIs for a set of users
                   using Context-Aware Access.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([gcp_user_access_binding, update_mask])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.UpdateGcpUserAccessBindingRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.UpdateGcpUserAccessBindingRequest):
            request = access_context_manager.UpdateGcpUserAccessBindingRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if gcp_user_access_binding is not None:
                request.gcp_user_access_binding = gcp_user_access_binding
            if update_mask is not None:
                request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_gcp_user_access_binding]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("gcp_user_access_binding.name", request.gcp_user_access_binding.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            gia_gcp_user_access_binding.GcpUserAccessBinding,
            metadata_type=access_context_manager.GcpUserAccessBindingOperationMetadata,
        )

        # Done; return the response.
        return response

    def delete_gcp_user_access_binding(self,
            request: access_context_manager.DeleteGcpUserAccessBindingRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Deletes a [GcpUserAccessBinding]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        Completion of this long-running operation does not necessarily
        signify that the binding deletion is deployed onto all affected
        users, which may take more time.

        Args:
            request (google.identity.accesscontextmanager_v1.types.DeleteGcpUserAccessBindingRequest):
                The request object. Request of
                [DeleteGcpUserAccessBinding]
                [google.identity.accesscontextmanager.v1.AccessContextManager.DeleteGcpUserAccessBinding].
            name (str):
                Required. Example:
                "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.protobuf.empty_pb2.Empty` A generic empty message that you can re-use to avoid defining duplicated
                   empty messages in your APIs. A typical example is to
                   use it as the request or the response type of an API
                   method. For instance:

                      service Foo {
                         rpc Bar(google.protobuf.Empty) returns
                         (google.protobuf.Empty);

                      }

                   The JSON representation for Empty is empty JSON
                   object {}.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a access_context_manager.DeleteGcpUserAccessBindingRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, access_context_manager.DeleteGcpUserAccessBindingRequest):
            request = access_context_manager.DeleteGcpUserAccessBindingRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if name is not None:
                request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete_gcp_user_access_binding]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=access_context_manager.GcpUserAccessBindingOperationMetadata,
        )

        # Done; return the response.
        return response





try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            "google-identity-accesscontextmanager",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "AccessContextManagerClient",
)
