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

from google.apps.alertcenter_v1beta1.services.alert_center_service import pagers
from google.apps.alertcenter_v1beta1.types import alertcenter
from google.protobuf import any_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from .transports.base import AlertCenterServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import AlertCenterServiceGrpcAsyncIOTransport
from .client import AlertCenterServiceClient


class AlertCenterServiceAsyncClient:
    """Google Workspace Alert Center API (beta)."""

    _client: AlertCenterServiceClient

    DEFAULT_ENDPOINT = AlertCenterServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = AlertCenterServiceClient.DEFAULT_MTLS_ENDPOINT

    common_billing_account_path = staticmethod(AlertCenterServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(AlertCenterServiceClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(AlertCenterServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(AlertCenterServiceClient.parse_common_folder_path)
    common_organization_path = staticmethod(AlertCenterServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(AlertCenterServiceClient.parse_common_organization_path)
    common_project_path = staticmethod(AlertCenterServiceClient.common_project_path)
    parse_common_project_path = staticmethod(AlertCenterServiceClient.parse_common_project_path)
    common_location_path = staticmethod(AlertCenterServiceClient.common_location_path)
    parse_common_location_path = staticmethod(AlertCenterServiceClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            AlertCenterServiceAsyncClient: The constructed client.
        """
        return AlertCenterServiceClient.from_service_account_info.__func__(AlertCenterServiceAsyncClient, info, *args, **kwargs)  # type: ignore

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
            AlertCenterServiceAsyncClient: The constructed client.
        """
        return AlertCenterServiceClient.from_service_account_file.__func__(AlertCenterServiceAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> AlertCenterServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            AlertCenterServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(AlertCenterServiceClient).get_transport_class, type(AlertCenterServiceClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, AlertCenterServiceTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the alert center service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.AlertCenterServiceTransport]): The
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
        self._client = AlertCenterServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def list_alerts(self,
            request: alertcenter.ListAlertsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListAlertsAsyncPager:
        r"""Lists the alerts.

        Args:
            request (:class:`google.apps.alertcenter_v1beta1.types.ListAlertsRequest`):
                The request object. An alert listing request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.apps.alertcenter_v1beta1.services.alert_center_service.pagers.ListAlertsAsyncPager:
                Response message for an alert listing
                request.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = alertcenter.ListAlertsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_alerts,
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
        response = pagers.ListAlertsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def get_alert(self,
            request: alertcenter.GetAlertRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> alertcenter.Alert:
        r"""Gets the specified alert. Attempting to get a nonexistent alert
        returns ``NOT_FOUND`` error.

        Args:
            request (:class:`google.apps.alertcenter_v1beta1.types.GetAlertRequest`):
                The request object. Request for a specific alert.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.apps.alertcenter_v1beta1.types.Alert:
                An alert affecting a customer.
        """
        # Create or coerce a protobuf request object.
        request = alertcenter.GetAlertRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_alert,
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

    async def delete_alert(self,
            request: alertcenter.DeleteAlertRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Marks the specified alert for deletion. An alert that has been
        marked for deletion is removed from Alert Center after 30 days.
        Marking an alert for deletion has no effect on an alert which
        has already been marked for deletion. Attempting to mark a
        nonexistent alert for deletion results in a ``NOT_FOUND`` error.

        Args:
            request (:class:`google.apps.alertcenter_v1beta1.types.DeleteAlertRequest`):
                The request object. A request to mark a specific alert
                for deletion.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.
        request = alertcenter.DeleteAlertRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_alert,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Send the request.
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    async def undelete_alert(self,
            request: alertcenter.UndeleteAlertRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> alertcenter.Alert:
        r"""Restores, or "undeletes", an alert that was marked for deletion
        within the past 30 days. Attempting to undelete an alert which
        was marked for deletion over 30 days ago (which has been removed
        from the Alert Center database) or a nonexistent alert returns a
        ``NOT_FOUND`` error. Attempting to undelete an alert which has
        not been marked for deletion has no effect.

        Args:
            request (:class:`google.apps.alertcenter_v1beta1.types.UndeleteAlertRequest`):
                The request object. A request to undelete a specific
                alert that was marked for deletion.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.apps.alertcenter_v1beta1.types.Alert:
                An alert affecting a customer.
        """
        # Create or coerce a protobuf request object.
        request = alertcenter.UndeleteAlertRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.undelete_alert,
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

    async def create_alert_feedback(self,
            request: alertcenter.CreateAlertFeedbackRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> alertcenter.AlertFeedback:
        r"""Creates new feedback for an alert. Attempting to create a
        feedback for a non-existent alert returns ``NOT_FOUND`` error.
        Attempting to create a feedback for an alert that is marked for
        deletion returns \`FAILED_PRECONDITION' error.

        Args:
            request (:class:`google.apps.alertcenter_v1beta1.types.CreateAlertFeedbackRequest`):
                The request object. A request to create a new alert
                feedback.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.apps.alertcenter_v1beta1.types.AlertFeedback:
                A customer feedback about an alert.
        """
        # Create or coerce a protobuf request object.
        request = alertcenter.CreateAlertFeedbackRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_alert_feedback,
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

    async def list_alert_feedback(self,
            request: alertcenter.ListAlertFeedbackRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> alertcenter.ListAlertFeedbackResponse:
        r"""Lists all the feedback for an alert. Attempting to list
        feedbacks for a non-existent alert returns ``NOT_FOUND`` error.

        Args:
            request (:class:`google.apps.alertcenter_v1beta1.types.ListAlertFeedbackRequest`):
                The request object. An alert feedback listing request.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.apps.alertcenter_v1beta1.types.ListAlertFeedbackResponse:
                Response message for an alert
                feedback listing request.

        """
        # Create or coerce a protobuf request object.
        request = alertcenter.ListAlertFeedbackRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_alert_feedback,
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

    async def get_alert_metadata(self,
            request: alertcenter.GetAlertMetadataRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> alertcenter.AlertMetadata:
        r"""Returns the metadata of an alert. Attempting to get metadata for
        a non-existent alert returns ``NOT_FOUND`` error.

        Args:
            request (:class:`google.apps.alertcenter_v1beta1.types.GetAlertMetadataRequest`):
                The request object. Get the alert metadata.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.apps.alertcenter_v1beta1.types.AlertMetadata:
                An alert metadata.
        """
        # Create or coerce a protobuf request object.
        request = alertcenter.GetAlertMetadataRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_alert_metadata,
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

    async def get_settings(self,
            request: alertcenter.GetSettingsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> alertcenter.Settings:
        r"""Returns customer-level settings.

        Args:
            request (:class:`google.apps.alertcenter_v1beta1.types.GetSettingsRequest`):
                The request object. Get the customer level settings.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.apps.alertcenter_v1beta1.types.Settings:
                Customer-level settings.
        """
        # Create or coerce a protobuf request object.
        request = alertcenter.GetSettingsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_settings,
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

    async def update_settings(self,
            request: alertcenter.UpdateSettingsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> alertcenter.Settings:
        r"""Updates the customer-level settings.

        Args:
            request (:class:`google.apps.alertcenter_v1beta1.types.UpdateSettingsRequest`):
                The request object. Update the customer level settings.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.apps.alertcenter_v1beta1.types.Settings:
                Customer-level settings.
        """
        # Create or coerce a protobuf request object.
        request = alertcenter.UpdateSettingsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_settings,
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

    async def batch_delete_alerts(self,
            request: alertcenter.BatchDeleteAlertsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> alertcenter.BatchDeleteAlertsResponse:
        r"""Performs batch delete operation on alerts.

        Args:
            request (:class:`google.apps.alertcenter_v1beta1.types.BatchDeleteAlertsRequest`):
                The request object. A request to perform batch delete on
                alerts.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.apps.alertcenter_v1beta1.types.BatchDeleteAlertsResponse:
                Response to batch delete operation on
                alerts.

        """
        # Create or coerce a protobuf request object.
        request = alertcenter.BatchDeleteAlertsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.batch_delete_alerts,
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

    async def batch_undelete_alerts(self,
            request: alertcenter.BatchUndeleteAlertsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> alertcenter.BatchUndeleteAlertsResponse:
        r"""Performs batch undelete operation on alerts.

        Args:
            request (:class:`google.apps.alertcenter_v1beta1.types.BatchUndeleteAlertsRequest`):
                The request object. A request to perform batch undelete
                on alerts.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.apps.alertcenter_v1beta1.types.BatchUndeleteAlertsResponse:
                Response to batch undelete operation
                on alerts.

        """
        # Create or coerce a protobuf request object.
        request = alertcenter.BatchUndeleteAlertsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.batch_undelete_alerts,
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
            "google-apps-alertcenter",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "AlertCenterServiceAsyncClient",
)
