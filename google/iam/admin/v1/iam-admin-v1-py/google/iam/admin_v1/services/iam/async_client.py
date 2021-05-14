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

from google.iam.admin_v1.services.iam import pagers
from google.iam.admin_v1.types import iam
from google.iam.v1 import iam_policy_pb2  # type: ignore
from google.iam.v1 import policy_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from .transports.base import IAMTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import IAMGrpcAsyncIOTransport
from .client import IAMClient


class IAMAsyncClient:
    """Creates and manages Identity and Access Management (IAM) resources.

    You can use this service to work with all of the following
    resources:

    -  **Service accounts**, which identify an application or a virtual
       machine (VM) instance rather than a person
    -  **Service account keys**, which service accounts use to
       authenticate with Google APIs
    -  **IAM policies for service accounts**, which specify the roles
       that a member has for the service account
    -  **IAM custom roles**, which help you limit the number of
       permissions that you grant to members

    In addition, you can use this service to complete the following
    tasks, among others:

    -  Test whether a service account can use specific permissions
    -  Check which roles you can grant for a specific resource
    -  Lint, or validate, condition expressions in an IAM policy
    """

    _client: IAMClient

    DEFAULT_ENDPOINT = IAMClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = IAMClient.DEFAULT_MTLS_ENDPOINT

    key_path = staticmethod(IAMClient.key_path)
    parse_key_path = staticmethod(IAMClient.parse_key_path)
    service_account_path = staticmethod(IAMClient.service_account_path)
    parse_service_account_path = staticmethod(IAMClient.parse_service_account_path)
    common_billing_account_path = staticmethod(IAMClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(IAMClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(IAMClient.common_folder_path)
    parse_common_folder_path = staticmethod(IAMClient.parse_common_folder_path)
    common_organization_path = staticmethod(IAMClient.common_organization_path)
    parse_common_organization_path = staticmethod(IAMClient.parse_common_organization_path)
    common_project_path = staticmethod(IAMClient.common_project_path)
    parse_common_project_path = staticmethod(IAMClient.parse_common_project_path)
    common_location_path = staticmethod(IAMClient.common_location_path)
    parse_common_location_path = staticmethod(IAMClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            IAMAsyncClient: The constructed client.
        """
        return IAMClient.from_service_account_info.__func__(IAMAsyncClient, info, *args, **kwargs)  # type: ignore

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
            IAMAsyncClient: The constructed client.
        """
        return IAMClient.from_service_account_file.__func__(IAMAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> IAMTransport:
        """Returns the transport used by the client instance.

        Returns:
            IAMTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(IAMClient).get_transport_class, type(IAMClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, IAMTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the iam client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.IAMTransport]): The
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
        self._client = IAMClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def list_service_accounts(self,
            request: iam.ListServiceAccountsRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListServiceAccountsAsyncPager:
        r"""Lists every [ServiceAccount][google.iam.admin.v1.ServiceAccount]
        that belongs to a specific project.

        Args:
            request (:class:`google.iam.admin_v1.types.ListServiceAccountsRequest`):
                The request object. The service account list request.
            name (:class:`str`):
                Required. The resource name of the project associated
                with the service accounts, such as
                ``projects/my-project-123``.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.services.iam.pagers.ListServiceAccountsAsyncPager:
                The service account list response.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = iam.ListServiceAccountsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_service_accounts,
            default_retry=retries.Retry(
initial=0.1,maximum=60.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.DeadlineExceeded,
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

        # This method is paged; wrap the response in a pager, which provides
        # an `__aiter__` convenience method.
        response = pagers.ListServiceAccountsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def get_service_account(self,
            request: iam.GetServiceAccountRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.ServiceAccount:
        r"""Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        Args:
            request (:class:`google.iam.admin_v1.types.GetServiceAccountRequest`):
                The request object. The service account get request.
            name (:class:`str`):
                Required. The resource name of the service account in
                the following format:
                ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``.
                Using ``-`` as a wildcard for the ``PROJECT_ID`` will
                infer the project from the account. The ``ACCOUNT``
                value can be the ``email`` address or the ``unique_id``
                of the service account.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.ServiceAccount:
                An IAM service account.

                   A service account is an account for an application or
                   a virtual machine (VM) instance, not a person. You
                   can use a service account to call Google APIs. To
                   learn more, read the [overview of service
                   accounts](\ https://cloud.google.com/iam/help/service-accounts/overview).

                   When you create a service account, you specify the
                   project ID that owns the service account, as well as
                   a name that must be unique within the project. IAM
                   uses these values to create an email address that
                   identifies the service account.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = iam.GetServiceAccountRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_service_account,
            default_retry=retries.Retry(
initial=0.1,maximum=60.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.DeadlineExceeded,
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

    async def create_service_account(self,
            request: iam.CreateServiceAccountRequest = None,
            *,
            name: str = None,
            account_id: str = None,
            service_account: iam.ServiceAccount = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.ServiceAccount:
        r"""Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        Args:
            request (:class:`google.iam.admin_v1.types.CreateServiceAccountRequest`):
                The request object. The service account create request.
            name (:class:`str`):
                Required. The resource name of the project associated
                with the service accounts, such as
                ``projects/my-project-123``.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            account_id (:class:`str`):
                Required. The account id that is used to generate the
                service account email address and a stable unique id. It
                is unique within a project, must be 6-30 characters
                long, and match the regular expression
                ``[a-z]([-a-z0-9]*[a-z0-9])`` to comply with RFC1035.

                This corresponds to the ``account_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            service_account (:class:`google.iam.admin_v1.types.ServiceAccount`):
                The [ServiceAccount][google.iam.admin.v1.ServiceAccount]
                resource to create. Currently, only the following values
                are user assignable: ``display_name`` and
                ``description``.

                This corresponds to the ``service_account`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.ServiceAccount:
                An IAM service account.

                   A service account is an account for an application or
                   a virtual machine (VM) instance, not a person. You
                   can use a service account to call Google APIs. To
                   learn more, read the [overview of service
                   accounts](\ https://cloud.google.com/iam/help/service-accounts/overview).

                   When you create a service account, you specify the
                   project ID that owns the service account, as well as
                   a name that must be unique within the project. IAM
                   uses these values to create an email address that
                   identifies the service account.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name, account_id, service_account])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = iam.CreateServiceAccountRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name
        if account_id is not None:
            request.account_id = account_id
        if service_account is not None:
            request.service_account = service_account

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_service_account,
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

    async def update_service_account(self,
            request: iam.ServiceAccount = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.ServiceAccount:
        r"""**Note:** We are in the process of deprecating this method. Use
        [PatchServiceAccount][google.iam.admin.v1.IAM.PatchServiceAccount]
        instead.

        Updates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        You can update only the ``display_name`` and ``description``
        fields.

        Args:
            request (:class:`google.iam.admin_v1.types.ServiceAccount`):
                The request object. An IAM service account.
                A service account is an account for an application or a
                virtual machine (VM) instance, not a person. You can use
                a service account to call Google APIs. To learn more,
                read the [overview of service
                accounts](https://cloud.google.com/iam/help/service-
                accounts/overview).
                When you create a service account, you specify the
                project ID that owns the service account, as well as a
                name that must be unique within the project. IAM uses
                these values to create an email address that identifies
                the service account.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.ServiceAccount:
                An IAM service account.

                   A service account is an account for an application or
                   a virtual machine (VM) instance, not a person. You
                   can use a service account to call Google APIs. To
                   learn more, read the [overview of service
                   accounts](\ https://cloud.google.com/iam/help/service-accounts/overview).

                   When you create a service account, you specify the
                   project ID that owns the service account, as well as
                   a name that must be unique within the project. IAM
                   uses these values to create an email address that
                   identifies the service account.

        """
        # Create or coerce a protobuf request object.
        request = iam.ServiceAccount(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_service_account,
            default_retry=retries.Retry(
initial=0.1,maximum=60.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.DeadlineExceeded,
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

    async def patch_service_account(self,
            request: iam.PatchServiceAccountRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.ServiceAccount:
        r"""Patches a [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        Args:
            request (:class:`google.iam.admin_v1.types.PatchServiceAccountRequest`):
                The request object. The request for
                [PatchServiceAccount][google.iam.admin.v1.PatchServiceAccount].
                You can patch only the `display_name` and `description`
                fields. You must use the `update_mask` field to specify
                which of these fields you want to patch.
                Only the fields specified in the request are guaranteed
                to be returned in the response. Other fields may be
                empty in the response.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.ServiceAccount:
                An IAM service account.

                   A service account is an account for an application or
                   a virtual machine (VM) instance, not a person. You
                   can use a service account to call Google APIs. To
                   learn more, read the [overview of service
                   accounts](\ https://cloud.google.com/iam/help/service-accounts/overview).

                   When you create a service account, you specify the
                   project ID that owns the service account, as well as
                   a name that must be unique within the project. IAM
                   uses these values to create an email address that
                   identifies the service account.

        """
        # Create or coerce a protobuf request object.
        request = iam.PatchServiceAccountRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.patch_service_account,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("service_account.name", request.service_account.name),
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

    async def delete_service_account(self,
            request: iam.DeleteServiceAccountRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        **Warning:** After you delete a service account, you might not
        be able to undelete it. If you know that you need to re-enable
        the service account in the future, use
        [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount]
        instead.

        If you delete a service account, IAM permanently removes the
        service account 30 days later. Google Cloud cannot recover the
        service account after it is permanently removed, even if you
        file a support request.

        To help avoid unplanned outages, we recommend that you disable
        the service account before you delete it. Use
        [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount]
        to disable the service account, then wait at least 24 hours and
        watch for unintended consequences. If there are no unintended
        consequences, you can delete the service account.

        Args:
            request (:class:`google.iam.admin_v1.types.DeleteServiceAccountRequest`):
                The request object. The service account delete request.
            name (:class:`str`):
                Required. The resource name of the service account in
                the following format:
                ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``.
                Using ``-`` as a wildcard for the ``PROJECT_ID`` will
                infer the project from the account. The ``ACCOUNT``
                value can be the ``email`` address or the ``unique_id``
                of the service account.

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
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = iam.DeleteServiceAccountRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_service_account,
            default_retry=retries.Retry(
initial=0.1,maximum=60.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.DeadlineExceeded,
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
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    async def undelete_service_account(self,
            request: iam.UndeleteServiceAccountRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.UndeleteServiceAccountResponse:
        r"""Restores a deleted
        [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        **Important:** It is not always possible to restore a deleted
        service account. Use this method only as a last resort.

        After you delete a service account, IAM permanently removes the
        service account 30 days later. There is no way to restore a
        deleted service account that has been permanently removed.

        Args:
            request (:class:`google.iam.admin_v1.types.UndeleteServiceAccountRequest`):
                The request object. The service account undelete
                request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.UndeleteServiceAccountResponse:

        """
        # Create or coerce a protobuf request object.
        request = iam.UndeleteServiceAccountRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.undelete_service_account,
            default_timeout=None,
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

    async def enable_service_account(self,
            request: iam.EnableServiceAccountRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Enables a [ServiceAccount][google.iam.admin.v1.ServiceAccount]
        that was disabled by
        [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount].

        If the service account is already enabled, then this method has
        no effect.

        If the service account was disabled by other means—for example,
        if Google disabled the service account because it was
        compromised—you cannot use this method to enable the service
        account.

        Args:
            request (:class:`google.iam.admin_v1.types.EnableServiceAccountRequest`):
                The request object. The service account enable request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.
        request = iam.EnableServiceAccountRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.enable_service_account,
            default_timeout=None,
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
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    async def disable_service_account(self,
            request: iam.DisableServiceAccountRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Disables a [ServiceAccount][google.iam.admin.v1.ServiceAccount]
        immediately.

        If an application uses the service account to authenticate, that
        application can no longer call Google APIs or access Google
        Cloud resources. Existing access tokens for the service account
        are rejected, and requests for new access tokens will fail.

        To re-enable the service account, use
        [EnableServiceAccount][google.iam.admin.v1.IAM.EnableServiceAccount].
        After you re-enable the service account, its existing access
        tokens will be accepted, and you can request new access tokens.

        To help avoid unplanned outages, we recommend that you disable
        the service account before you delete it. Use this method to
        disable the service account, then wait at least 24 hours and
        watch for unintended consequences. If there are no unintended
        consequences, you can delete the service account with
        [DeleteServiceAccount][google.iam.admin.v1.IAM.DeleteServiceAccount].

        Args:
            request (:class:`google.iam.admin_v1.types.DisableServiceAccountRequest`):
                The request object. The service account disable request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.
        request = iam.DisableServiceAccountRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.disable_service_account,
            default_timeout=None,
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
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    async def list_service_account_keys(self,
            request: iam.ListServiceAccountKeysRequest = None,
            *,
            name: str = None,
            key_types: Sequence[iam.ListServiceAccountKeysRequest.KeyType] = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.ListServiceAccountKeysResponse:
        r"""Lists every
        [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] for a
        service account.

        Args:
            request (:class:`google.iam.admin_v1.types.ListServiceAccountKeysRequest`):
                The request object. The service account keys list
                request.
            name (:class:`str`):
                Required. The resource name of the service account in
                the following format:
                ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``.

                Using ``-`` as a wildcard for the ``PROJECT_ID``, will
                infer the project from the account. The ``ACCOUNT``
                value can be the ``email`` address or the ``unique_id``
                of the service account.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            key_types (:class:`Sequence[google.iam.admin_v1.types.ListServiceAccountKeysRequest.KeyType]`):
                Filters the types of keys the user
                wants to include in the list response.
                Duplicate key types are not allowed. If
                no key type is provided, all keys are
                returned.

                This corresponds to the ``key_types`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.ListServiceAccountKeysResponse:
                The service account keys list
                response.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name, key_types])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = iam.ListServiceAccountKeysRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name
        if key_types:
            request.key_types.extend(key_types)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_service_account_keys,
            default_retry=retries.Retry(
initial=0.1,maximum=60.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.DeadlineExceeded,
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

    async def get_service_account_key(self,
            request: iam.GetServiceAccountKeyRequest = None,
            *,
            name: str = None,
            public_key_type: iam.ServiceAccountPublicKeyType = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.ServiceAccountKey:
        r"""Gets a
        [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].

        Args:
            request (:class:`google.iam.admin_v1.types.GetServiceAccountKeyRequest`):
                The request object. The service account key get by id
                request.
            name (:class:`str`):
                Required. The resource name of the service account key
                in the following format:
                ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}``.

                Using ``-`` as a wildcard for the ``PROJECT_ID`` will
                infer the project from the account. The ``ACCOUNT``
                value can be the ``email`` address or the ``unique_id``
                of the service account.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            public_key_type (:class:`google.iam.admin_v1.types.ServiceAccountPublicKeyType`):
                The output format of the public key requested. X509_PEM
                is the default output format.

                This corresponds to the ``public_key_type`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.ServiceAccountKey:
                Represents a service account key.
                A service account has two sets of key-
                pairs: user-managed, and system-managed.

                User-managed key-pairs can be created
                and deleted by users.  Users are
                responsible for rotating these keys
                periodically to ensure security of their
                service accounts.  Users retain the
                private key of these key-pairs, and
                Google retains ONLY the public key.

                System-managed keys are automatically
                rotated by Google, and are used for
                signing for a maximum of two weeks. The
                rotation process is probabilistic, and
                usage of the new key will gradually ramp
                up and down over the key's lifetime.

                If you cache the public key set for a
                service account, we recommend that you
                update the cache every 15 minutes. User-
                managed keys can be added and removed at
                any time, so it is important to update
                the cache frequently. For Google-managed
                keys, Google will publish a key at least
                6 hours before it is first used for
                signing and will keep publishing it for
                at least 6 hours after it was last used
                for signing.

                Public keys for all service accounts are
                also published at the OAuth2 Service
                Account API.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name, public_key_type])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = iam.GetServiceAccountKeyRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name
        if public_key_type is not None:
            request.public_key_type = public_key_type

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_service_account_key,
            default_retry=retries.Retry(
initial=0.1,maximum=60.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.DeadlineExceeded,
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

    async def create_service_account_key(self,
            request: iam.CreateServiceAccountKeyRequest = None,
            *,
            name: str = None,
            private_key_type: iam.ServiceAccountPrivateKeyType = None,
            key_algorithm: iam.ServiceAccountKeyAlgorithm = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.ServiceAccountKey:
        r"""Creates a
        [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].

        Args:
            request (:class:`google.iam.admin_v1.types.CreateServiceAccountKeyRequest`):
                The request object. The service account key create
                request.
            name (:class:`str`):
                Required. The resource name of the service account in
                the following format:
                ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``.
                Using ``-`` as a wildcard for the ``PROJECT_ID`` will
                infer the project from the account. The ``ACCOUNT``
                value can be the ``email`` address or the ``unique_id``
                of the service account.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            private_key_type (:class:`google.iam.admin_v1.types.ServiceAccountPrivateKeyType`):
                The output format of the private key. The default value
                is ``TYPE_GOOGLE_CREDENTIALS_FILE``, which is the Google
                Credentials File format.

                This corresponds to the ``private_key_type`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            key_algorithm (:class:`google.iam.admin_v1.types.ServiceAccountKeyAlgorithm`):
                Which type of key and algorithm to
                use for the key. The default is
                currently a 2K RSA key.  However this
                may change in the future.

                This corresponds to the ``key_algorithm`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.ServiceAccountKey:
                Represents a service account key.
                A service account has two sets of key-
                pairs: user-managed, and system-managed.

                User-managed key-pairs can be created
                and deleted by users.  Users are
                responsible for rotating these keys
                periodically to ensure security of their
                service accounts.  Users retain the
                private key of these key-pairs, and
                Google retains ONLY the public key.

                System-managed keys are automatically
                rotated by Google, and are used for
                signing for a maximum of two weeks. The
                rotation process is probabilistic, and
                usage of the new key will gradually ramp
                up and down over the key's lifetime.

                If you cache the public key set for a
                service account, we recommend that you
                update the cache every 15 minutes. User-
                managed keys can be added and removed at
                any time, so it is important to update
                the cache frequently. For Google-managed
                keys, Google will publish a key at least
                6 hours before it is first used for
                signing and will keep publishing it for
                at least 6 hours after it was last used
                for signing.

                Public keys for all service accounts are
                also published at the OAuth2 Service
                Account API.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name, private_key_type, key_algorithm])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = iam.CreateServiceAccountKeyRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name
        if private_key_type is not None:
            request.private_key_type = private_key_type
        if key_algorithm is not None:
            request.key_algorithm = key_algorithm

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_service_account_key,
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

    async def upload_service_account_key(self,
            request: iam.UploadServiceAccountKeyRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.ServiceAccountKey:
        r"""Creates a
        [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey],
        using a public key that you provide.

        Args:
            request (:class:`google.iam.admin_v1.types.UploadServiceAccountKeyRequest`):
                The request object. The service account key upload
                request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.ServiceAccountKey:
                Represents a service account key.
                A service account has two sets of key-
                pairs: user-managed, and system-managed.

                User-managed key-pairs can be created
                and deleted by users.  Users are
                responsible for rotating these keys
                periodically to ensure security of their
                service accounts.  Users retain the
                private key of these key-pairs, and
                Google retains ONLY the public key.

                System-managed keys are automatically
                rotated by Google, and are used for
                signing for a maximum of two weeks. The
                rotation process is probabilistic, and
                usage of the new key will gradually ramp
                up and down over the key's lifetime.

                If you cache the public key set for a
                service account, we recommend that you
                update the cache every 15 minutes. User-
                managed keys can be added and removed at
                any time, so it is important to update
                the cache frequently. For Google-managed
                keys, Google will publish a key at least
                6 hours before it is first used for
                signing and will keep publishing it for
                at least 6 hours after it was last used
                for signing.

                Public keys for all service accounts are
                also published at the OAuth2 Service
                Account API.

        """
        # Create or coerce a protobuf request object.
        request = iam.UploadServiceAccountKeyRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.upload_service_account_key,
            default_timeout=None,
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

    async def delete_service_account_key(self,
            request: iam.DeleteServiceAccountKeyRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Deletes a
        [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
        Deleting a service account key does not revoke short-lived
        credentials that have been issued based on the service account
        key.

        Args:
            request (:class:`google.iam.admin_v1.types.DeleteServiceAccountKeyRequest`):
                The request object. The service account key delete
                request.
            name (:class:`str`):
                Required. The resource name of the service account key
                in the following format:
                ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}``.
                Using ``-`` as a wildcard for the ``PROJECT_ID`` will
                infer the project from the account. The ``ACCOUNT``
                value can be the ``email`` address or the ``unique_id``
                of the service account.

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
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = iam.DeleteServiceAccountKeyRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_service_account_key,
            default_retry=retries.Retry(
initial=0.1,maximum=60.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.DeadlineExceeded,
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
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    async def sign_blob(self,
            request: iam.SignBlobRequest = None,
            *,
            name: str = None,
            bytes_to_sign: bytes = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.SignBlobResponse:
        r"""**Note:** This method is deprecated. Use the
        ```signBlob`` <https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob>`__
        method in the IAM Service Account Credentials API instead. If
        you currently use this method, see the `migration
        guide <https://cloud.google.com/iam/help/credentials/migrate-api>`__
        for instructions.

        Signs a blob using the system-managed private key for a
        [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        Args:
            request (:class:`google.iam.admin_v1.types.SignBlobRequest`):
                The request object. Deprecated. [Migrate to Service
                Account Credentials
                API](https://cloud.google.com/iam/help/credentials/migrate-
                api).
                The service account sign blob request.
            name (:class:`str`):
                Required. Deprecated. `Migrate to Service Account
                Credentials
                API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

                The resource name of the service account in the
                following format:
                ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``.
                Using ``-`` as a wildcard for the ``PROJECT_ID`` will
                infer the project from the account. The ``ACCOUNT``
                value can be the ``email`` address or the ``unique_id``
                of the service account.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            bytes_to_sign (:class:`bytes`):
                Required. Deprecated. `Migrate to Service Account
                Credentials
                API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

                The bytes to sign.

                This corresponds to the ``bytes_to_sign`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.SignBlobResponse:
                Deprecated. [Migrate to Service Account Credentials
                   API](\ https://cloud.google.com/iam/help/credentials/migrate-api).

                   The service account sign blob response.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name, bytes_to_sign])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = iam.SignBlobRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name
        if bytes_to_sign is not None:
            request.bytes_to_sign = bytes_to_sign

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.sign_blob,
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

    async def sign_jwt(self,
            request: iam.SignJwtRequest = None,
            *,
            name: str = None,
            payload: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.SignJwtResponse:
        r"""**Note:** This method is deprecated. Use the
        ```signJwt`` <https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt>`__
        method in the IAM Service Account Credentials API instead. If
        you currently use this method, see the `migration
        guide <https://cloud.google.com/iam/help/credentials/migrate-api>`__
        for instructions.

        Signs a JSON Web Token (JWT) using the system-managed private
        key for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        Args:
            request (:class:`google.iam.admin_v1.types.SignJwtRequest`):
                The request object. Deprecated. [Migrate to Service
                Account Credentials
                API](https://cloud.google.com/iam/help/credentials/migrate-
                api).
                The service account sign JWT request.
            name (:class:`str`):
                Required. Deprecated. `Migrate to Service Account
                Credentials
                API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

                The resource name of the service account in the
                following format:
                ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``.
                Using ``-`` as a wildcard for the ``PROJECT_ID`` will
                infer the project from the account. The ``ACCOUNT``
                value can be the ``email`` address or the ``unique_id``
                of the service account.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            payload (:class:`str`):
                Required. Deprecated. `Migrate to Service Account
                Credentials
                API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

                The JWT payload to sign. Must be a serialized JSON
                object that contains a JWT Claims Set. For example:
                ``{"sub": "user@example.com", "iat": 313435}``

                If the JWT Claims Set contains an expiration time
                (``exp``) claim, it must be an integer timestamp that is
                not in the past and no more than 1 hour in the future.

                If the JWT Claims Set does not contain an expiration
                time (``exp``) claim, this claim is added automatically,
                with a timestamp that is 1 hour in the future.

                This corresponds to the ``payload`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.SignJwtResponse:
                Deprecated. [Migrate to Service Account Credentials
                   API](\ https://cloud.google.com/iam/help/credentials/migrate-api).

                   The service account sign JWT response.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name, payload])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = iam.SignJwtRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name
        if payload is not None:
            request.payload = payload

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.sign_jwt,
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

    async def get_iam_policy(self,
            request: iam_policy_pb2.GetIamPolicyRequest = None,
            *,
            resource: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> policy_pb2.Policy:
        r"""Gets the IAM policy that is attached to a
        [ServiceAccount][google.iam.admin.v1.ServiceAccount]. This IAM
        policy specifies which members have access to the service
        account.

        This method does not tell you whether the service account has
        been granted any roles on other resources. To check whether a
        service account has role grants on a resource, use the
        ``getIamPolicy`` method for that resource. For example, to view
        the role grants for a project, call the Resource Manager API's
        ```projects.getIamPolicy`` <https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy>`__
        method.

        Args:
            request (:class:`google.iam.v1.iam_policy_pb2.GetIamPolicyRequest`):
                The request object. Request message for `GetIamPolicy`
                method.
            resource (:class:`str`):
                REQUIRED: The resource for which the
                policy is being requested. See the
                operation documentation for the
                appropriate value for this field.

                This corresponds to the ``resource`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
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
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([resource])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

         # The request isn't a proto-plus wrapped type,
        # so it must be constructed via keyword expansion.
        if isinstance(request, dict):
            request = iam_policy_pb2.GetIamPolicyRequest(**request)
        elif not request:
            request = iam_policy_pb2.GetIamPolicyRequest(resource=resource, )

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_iam_policy,
            default_timeout=60.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("resource", request.resource),
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

    async def set_iam_policy(self,
            request: iam_policy_pb2.SetIamPolicyRequest = None,
            *,
            resource: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> policy_pb2.Policy:
        r"""Sets the IAM policy that is attached to a
        [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        Use this method to grant or revoke access to the service
        account. For example, you could grant a member the ability to
        impersonate the service account.

        This method does not enable the service account to access other
        resources. To grant roles to a service account on a resource,
        follow these steps:

        1. Call the resource's ``getIamPolicy`` method to get its
           current IAM policy.
        2. Edit the policy so that it binds the service account to an
           IAM role for the resource.
        3. Call the resource's ``setIamPolicy`` method to update its IAM
           policy.

        For detailed instructions, see `Granting roles to a service
        account for specific
        resources <https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts>`__.

        Args:
            request (:class:`google.iam.v1.iam_policy_pb2.SetIamPolicyRequest`):
                The request object. Request message for `SetIamPolicy`
                method.
            resource (:class:`str`):
                REQUIRED: The resource for which the
                policy is being specified. See the
                operation documentation for the
                appropriate value for this field.

                This corresponds to the ``resource`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
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
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([resource])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

         # The request isn't a proto-plus wrapped type,
        # so it must be constructed via keyword expansion.
        if isinstance(request, dict):
            request = iam_policy_pb2.SetIamPolicyRequest(**request)
        elif not request:
            request = iam_policy_pb2.SetIamPolicyRequest(resource=resource, )

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.set_iam_policy,
            default_timeout=60.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("resource", request.resource),
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

    async def test_iam_permissions(self,
            request: iam_policy_pb2.TestIamPermissionsRequest = None,
            *,
            resource: str = None,
            permissions: Sequence[str] = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam_policy_pb2.TestIamPermissionsResponse:
        r"""Tests whether the caller has the specified permissions on a
        [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        Args:
            request (:class:`google.iam.v1.iam_policy_pb2.TestIamPermissionsRequest`):
                The request object. Request message for
                `TestIamPermissions` method.
            resource (:class:`str`):
                REQUIRED: The resource for which the
                policy detail is being requested. See
                the operation documentation for the
                appropriate value for this field.

                This corresponds to the ``resource`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            permissions (:class:`Sequence[str]`):
                The set of permissions to check for the ``resource``.
                Permissions with wildcards (such as '*' or 'storage.*')
                are not allowed. For more information see `IAM
                Overview <https://cloud.google.com/iam/docs/overview#permissions>`__.

                This corresponds to the ``permissions`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
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
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([resource, permissions])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

         # The request isn't a proto-plus wrapped type,
        # so it must be constructed via keyword expansion.
        if isinstance(request, dict):
            request = iam_policy_pb2.TestIamPermissionsRequest(**request)
        elif not request:
            request = iam_policy_pb2.TestIamPermissionsRequest(resource=resource, permissions=permissions, )

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.test_iam_permissions,
            default_timeout=60.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("resource", request.resource),
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

    async def query_grantable_roles(self,
            request: iam.QueryGrantableRolesRequest = None,
            *,
            full_resource_name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.QueryGrantableRolesAsyncPager:
        r"""Lists roles that can be granted on a Google Cloud
        resource. A role is grantable if the IAM policy for the
        resource can contain bindings to the role.

        Args:
            request (:class:`google.iam.admin_v1.types.QueryGrantableRolesRequest`):
                The request object. The grantable role query request.
            full_resource_name (:class:`str`):
                Required. The full resource name to query from the list
                of grantable roles.

                The name follows the Google Cloud Platform resource
                format. For example, a Cloud Platform project with id
                ``my-project`` will be named
                ``//cloudresourcemanager.googleapis.com/projects/my-project``.

                This corresponds to the ``full_resource_name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.services.iam.pagers.QueryGrantableRolesAsyncPager:
                The grantable role query response.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([full_resource_name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = iam.QueryGrantableRolesRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if full_resource_name is not None:
            request.full_resource_name = full_resource_name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.query_grantable_roles,
            default_timeout=60.0,
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
        response = pagers.QueryGrantableRolesAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def list_roles(self,
            request: iam.ListRolesRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListRolesAsyncPager:
        r"""Lists every predefined [Role][google.iam.admin.v1.Role] that IAM
        supports, or every custom role that is defined for an
        organization or project.

        Args:
            request (:class:`google.iam.admin_v1.types.ListRolesRequest`):
                The request object. The request to get all roles defined
                under a resource.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.services.iam.pagers.ListRolesAsyncPager:
                The response containing the roles
                defined under a resource.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = iam.ListRolesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_roles,
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
        response = pagers.ListRolesAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def get_role(self,
            request: iam.GetRoleRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.Role:
        r"""Gets the definition of a [Role][google.iam.admin.v1.Role].

        Args:
            request (:class:`google.iam.admin_v1.types.GetRoleRequest`):
                The request object. The request to get the definition of
                an existing role.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.Role:
                A role in the Identity and Access
                Management API.

        """
        # Create or coerce a protobuf request object.
        request = iam.GetRoleRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_role,
            default_timeout=None,
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

    async def create_role(self,
            request: iam.CreateRoleRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.Role:
        r"""Creates a new custom [Role][google.iam.admin.v1.Role].

        Args:
            request (:class:`google.iam.admin_v1.types.CreateRoleRequest`):
                The request object. The request to create a new role.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.Role:
                A role in the Identity and Access
                Management API.

        """
        # Create or coerce a protobuf request object.
        request = iam.CreateRoleRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_role,
            default_timeout=None,
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

        # Done; return the response.
        return response

    async def update_role(self,
            request: iam.UpdateRoleRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.Role:
        r"""Updates the definition of a custom
        [Role][google.iam.admin.v1.Role].

        Args:
            request (:class:`google.iam.admin_v1.types.UpdateRoleRequest`):
                The request object. The request to update a role.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.Role:
                A role in the Identity and Access
                Management API.

        """
        # Create or coerce a protobuf request object.
        request = iam.UpdateRoleRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_role,
            default_timeout=None,
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

    async def delete_role(self,
            request: iam.DeleteRoleRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.Role:
        r"""Deletes a custom [Role][google.iam.admin.v1.Role].

        When you delete a custom role, the following changes occur
        immediately:

        -  You cannot bind a member to the custom role in an IAM
           [Policy][google.iam.v1.Policy].
        -  Existing bindings to the custom role are not changed, but
           they have no effect.
        -  By default, the response from
           [ListRoles][google.iam.admin.v1.IAM.ListRoles] does not
           include the custom role.

        You have 7 days to undelete the custom role. After 7 days, the
        following changes occur:

        -  The custom role is permanently deleted and cannot be
           recovered.
        -  If an IAM policy contains a binding to the custom role, the
           binding is permanently removed.

        Args:
            request (:class:`google.iam.admin_v1.types.DeleteRoleRequest`):
                The request object. The request to delete an existing
                role.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.Role:
                A role in the Identity and Access
                Management API.

        """
        # Create or coerce a protobuf request object.
        request = iam.DeleteRoleRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_role,
            default_timeout=None,
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

    async def undelete_role(self,
            request: iam.UndeleteRoleRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.Role:
        r"""Undeletes a custom [Role][google.iam.admin.v1.Role].

        Args:
            request (:class:`google.iam.admin_v1.types.UndeleteRoleRequest`):
                The request object. The request to undelete an existing
                role.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.Role:
                A role in the Identity and Access
                Management API.

        """
        # Create or coerce a protobuf request object.
        request = iam.UndeleteRoleRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.undelete_role,
            default_timeout=None,
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

    async def query_testable_permissions(self,
            request: iam.QueryTestablePermissionsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.QueryTestablePermissionsAsyncPager:
        r"""Lists every permission that you can test on a
        resource. A permission is testable if you can check
        whether a member has that permission on the resource.

        Args:
            request (:class:`google.iam.admin_v1.types.QueryTestablePermissionsRequest`):
                The request object. A request to get permissions which
                can be tested on a resource.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.services.iam.pagers.QueryTestablePermissionsAsyncPager:
                The response containing permissions
                which can be tested on a resource.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = iam.QueryTestablePermissionsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.query_testable_permissions,
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
        response = pagers.QueryTestablePermissionsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def query_auditable_services(self,
            request: iam.QueryAuditableServicesRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.QueryAuditableServicesResponse:
        r"""Returns a list of services that allow you to opt into audit logs
        that are not generated by default.

        To learn more about audit logs, see the `Logging
        documentation <https://cloud.google.com/logging/docs/audit>`__.

        Args:
            request (:class:`google.iam.admin_v1.types.QueryAuditableServicesRequest`):
                The request object. A request to get the list of
                auditable services for a resource.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.QueryAuditableServicesResponse:
                A response containing a list of
                auditable services for a resource.

        """
        # Create or coerce a protobuf request object.
        request = iam.QueryAuditableServicesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.query_auditable_services,
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

    async def lint_policy(self,
            request: iam.LintPolicyRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> iam.LintPolicyResponse:
        r"""Lints, or validates, an IAM policy. Currently checks the
        [google.iam.v1.Binding.condition][google.iam.v1.Binding.condition]
        field, which contains a condition expression for a role binding.

        Successful calls to this method always return an HTTP ``200 OK``
        status code, even if the linter detects an issue in the IAM
        policy.

        Args:
            request (:class:`google.iam.admin_v1.types.LintPolicyRequest`):
                The request object. The request to lint a Cloud IAM
                policy object.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.iam.admin_v1.types.LintPolicyResponse:
                The response of a lint operation. An
                empty response indicates the operation
                was able to fully execute and no lint
                issue was found.

        """
        # Create or coerce a protobuf request object.
        request = iam.LintPolicyRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.lint_policy,
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
            "google-iam-admin",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "IAMAsyncClient",
)
