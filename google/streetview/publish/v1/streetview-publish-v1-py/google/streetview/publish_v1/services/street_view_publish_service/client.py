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
from typing import Dict, Optional, Sequence, Tuple, Type, Union
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

from google.protobuf import empty_pb2  # type: ignore
from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from google.rpc import status_pb2  # type: ignore
from google.streetview.publish_v1.services.street_view_publish_service import pagers
from google.streetview.publish_v1.types import resources
from google.streetview.publish_v1.types import rpcmessages
from .transports.base import StreetViewPublishServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc import StreetViewPublishServiceGrpcTransport
from .transports.grpc_asyncio import StreetViewPublishServiceGrpcAsyncIOTransport


class StreetViewPublishServiceClientMeta(type):
    """Metaclass for the StreetViewPublishService client.

    This provides class-level methods for building and retrieving
    support objects (e.g. transport) without polluting the client instance
    objects.
    """
    _transport_registry = OrderedDict()  # type: Dict[str, Type[StreetViewPublishServiceTransport]]
    _transport_registry["grpc"] = StreetViewPublishServiceGrpcTransport
    _transport_registry["grpc_asyncio"] = StreetViewPublishServiceGrpcAsyncIOTransport

    def get_transport_class(cls,
            label: str = None,
        ) -> Type[StreetViewPublishServiceTransport]:
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


class StreetViewPublishServiceClient(metaclass=StreetViewPublishServiceClientMeta):
    """Publishes and connects user-contributed photos on Street
    View.
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

    DEFAULT_ENDPOINT = "streetviewpublish.googleapis.com"
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
            StreetViewPublishServiceClient: The constructed client.
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
            StreetViewPublishServiceClient: The constructed client.
        """
        credentials = service_account.Credentials.from_service_account_file(
            filename)
        kwargs["credentials"] = credentials
        return cls(*args, **kwargs)

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> StreetViewPublishServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            StreetViewPublishServiceTransport: The transport used by the client
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
            transport: Union[str, StreetViewPublishServiceTransport, None] = None,
            client_options: Optional[client_options_lib.ClientOptions] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the street view publish service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, StreetViewPublishServiceTransport]): The
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
        if isinstance(transport, StreetViewPublishServiceTransport):
            # transport is a StreetViewPublishServiceTransport instance.
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

    def start_upload(self,
            request: Union[empty_pb2.Empty, dict] = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> resources.UploadRef:
        r"""Creates an upload session to start uploading photo bytes. The
        method uses the upload URL of the returned
        [UploadRef][google.streetview.publish.v1.UploadRef] to upload
        the bytes for the [Photo][google.streetview.publish.v1.Photo].

        In addition to the photo requirements shown in
        https://support.google.com/maps/answer/7012050?hl=en&ref_topic=6275604,
        the photo must meet the following requirements:

        -  Photo Sphere XMP metadata must be included in the photo
           medadata. See
           https://developers.google.com/streetview/spherical-metadata
           for the required fields.
        -  The pixel size of the photo must meet the size requirements
           listed in
           https://support.google.com/maps/answer/7012050?hl=en&ref_topic=6275604,
           and the photo must be a full 360 horizontally.

        After the upload completes, the method uses
        [UploadRef][google.streetview.publish.v1.UploadRef] with
        [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        to create the [Photo][google.streetview.publish.v1.Photo] object
        entry.

        Args:
            request (Union[google.protobuf.empty_pb2.Empty, dict]):
                The request object. A generic empty message that you can
                re-use to avoid defining duplicated empty messages in
                your APIs. A typical example is to use it as the request
                or the response type of an API method. For instance:

                    service Foo {
                      rpc Bar(google.protobuf.Empty) returns
                (google.protobuf.Empty);     }

                The JSON representation for `Empty` is empty JSON object
                `{}`.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.streetview.publish_v1.types.UploadRef:
                Upload reference for media files.
        """
        # Create or coerce a protobuf request object.
        if isinstance(request, dict):
            # The request isn't a proto-plus wrapped type,
            # so it must be constructed via keyword expansion.
            request = empty_pb2.Empty(**request)
        elif not request:
            # Null request, just make one.
            request = empty_pb2.Empty()

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.start_upload]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def create_photo(self,
            request: Union[rpcmessages.CreatePhotoRequest, dict] = None,
            *,
            photo: resources.Photo = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> resources.Photo:
        r"""After the client finishes uploading the photo with the returned
        [UploadRef][google.streetview.publish.v1.UploadRef],
        [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        publishes the uploaded
        [Photo][google.streetview.publish.v1.Photo] to Street View on
        Google Maps.

        Currently, the only way to set heading, pitch, and roll in
        CreatePhoto is through the `Photo Sphere XMP
        metadata <https://developers.google.com/streetview/spherical-metadata>`__
        in the photo bytes. CreatePhoto ignores the ``pose.heading``,
        ``pose.pitch``, ``pose.roll``, ``pose.altitude``, and
        ``pose.level`` fields in Pose.

        This method returns the following error codes:

        -  [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT]
           if the request is malformed or if the uploaded photo is not a
           360 photo.
        -  [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the
           upload reference does not exist.
        -  [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED]
           if the account has reached the storage limit.

        Args:
            request (Union[google.streetview.publish_v1.types.CreatePhotoRequest, dict]):
                The request object. Request to create a
                [Photo][google.streetview.publish.v1.Photo].
            photo (google.streetview.publish_v1.types.Photo):
                Required. Photo to create.
                This corresponds to the ``photo`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.streetview.publish_v1.types.Photo:
                Photo is used to store 360 photos
                along with photo metadata.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([photo])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a rpcmessages.CreatePhotoRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, rpcmessages.CreatePhotoRequest):
            request = rpcmessages.CreatePhotoRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if photo is not None:
                request.photo = photo

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.create_photo]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def get_photo(self,
            request: Union[rpcmessages.GetPhotoRequest, dict] = None,
            *,
            photo_id: str = None,
            view: rpcmessages.PhotoView = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> resources.Photo:
        r"""Gets the metadata of the specified
        [Photo][google.streetview.publish.v1.Photo].

        This method returns the following error codes:

        -  [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED]
           if the requesting user did not create the requested
           [Photo][google.streetview.publish.v1.Photo].
        -  [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the
           requested [Photo][google.streetview.publish.v1.Photo] does
           not exist.
        -  [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if
           the requested [Photo][google.streetview.publish.v1.Photo] is
           still being indexed.

        Args:
            request (Union[google.streetview.publish_v1.types.GetPhotoRequest, dict]):
                The request object. Request to get a
                [Photo][google.streetview.publish.v1.Photo].
                By default

                * does not return the download URL for the photo bytes.
                Parameters:

                * `view` controls if the download URL for the photo
                bytes is returned.
            photo_id (str):
                Required. ID of the
                [Photo][google.streetview.publish.v1.Photo].

                This corresponds to the ``photo_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            view (google.streetview.publish_v1.types.PhotoView):
                Specifies if a download URL for the photo bytes should
                be returned in the
                [Photo][google.streetview.publish.v1.Photo] response.

                This corresponds to the ``view`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.streetview.publish_v1.types.Photo:
                Photo is used to store 360 photos
                along with photo metadata.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([photo_id, view])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a rpcmessages.GetPhotoRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, rpcmessages.GetPhotoRequest):
            request = rpcmessages.GetPhotoRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if photo_id is not None:
                request.photo_id = photo_id
            if view is not None:
                request.view = view

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_photo]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def batch_get_photos(self,
            request: Union[rpcmessages.BatchGetPhotosRequest, dict] = None,
            *,
            photo_ids: Sequence[str] = None,
            view: rpcmessages.PhotoView = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> rpcmessages.BatchGetPhotosResponse:
        r"""Gets the metadata of the specified
        [Photo][google.streetview.publish.v1.Photo] batch.

        Note that if
        [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        fails, either critical fields are missing or there is an
        authentication error. Even if
        [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        succeeds, individual photos in the batch may have failures.
        These failures are specified in each
        [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        in
        [BatchGetPhotosResponse.results][google.streetview.publish.v1.BatchGetPhotosResponse.results].
        See
        [GetPhoto][google.streetview.publish.v1.StreetViewPublishService.GetPhoto]
        for specific failures that can occur per photo.

        Args:
            request (Union[google.streetview.publish_v1.types.BatchGetPhotosRequest, dict]):
                The request object. Request to get one or more
                [Photos][google.streetview.publish.v1.Photo]. By default
                * does not return the download URL for the photo bytes.
                Parameters:

                * `view` controls if the download URL for the photo
                bytes is returned.
            photo_ids (Sequence[str]):
                Required. IDs of the
                [Photos][google.streetview.publish.v1.Photo]. HTTP GET
                requests require the following syntax for the URL query
                parameter: ``photoIds=<id1>&photoIds=<id2>&...``.

                This corresponds to the ``photo_ids`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            view (google.streetview.publish_v1.types.PhotoView):
                Specifies if a download URL for the
                photo bytes should be returned in the
                Photo response.

                This corresponds to the ``view`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.streetview.publish_v1.types.BatchGetPhotosResponse:
                Response to batch get of
                [Photos][google.streetview.publish.v1.Photo].

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([photo_ids, view])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a rpcmessages.BatchGetPhotosRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, rpcmessages.BatchGetPhotosRequest):
            request = rpcmessages.BatchGetPhotosRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if photo_ids is not None:
                request.photo_ids = photo_ids
            if view is not None:
                request.view = view

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.batch_get_photos]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def list_photos(self,
            request: Union[rpcmessages.ListPhotosRequest, dict] = None,
            *,
            view: rpcmessages.PhotoView = None,
            filter: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListPhotosPager:
        r"""Lists all the [Photos][google.streetview.publish.v1.Photo] that
        belong to the user.

        .. raw:: html

            <aside class="note"><b>Note:</b> Recently created photos that are still
            being indexed are not returned in the response.</aside>

        Args:
            request (Union[google.streetview.publish_v1.types.ListPhotosRequest, dict]):
                The request object. Request to list all photos that
                belong to the user sending the request.
                By default

                * does not return the download URL for the photo bytes.
                Parameters:

                * `view` controls if the download URL for the photo
                bytes is returned. * `pageSize` determines the maximum
                number of photos to return. * `pageToken` is the next
                page token value returned from a previous
                [ListPhotos][google.streetview.publish.v1.StreetViewPublishService.ListPhotos]
                request, if any.
                * `filter` allows filtering by a given parameter.
                'placeId' is the only parameter supported at the moment.
            view (google.streetview.publish_v1.types.PhotoView):
                Specifies if a download URL for the
                photos bytes should be returned in the
                Photos response.

                This corresponds to the ``view`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            filter (str):
                The filter expression. For example:
                ``placeId=ChIJj61dQgK6j4AR4GeTYWZsKWw``.

                The only filter supported at the moment is ``placeId``.

                This corresponds to the ``filter`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.streetview.publish_v1.services.street_view_publish_service.pagers.ListPhotosPager:
                Response to list all photos that
                belong to a user.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([view, filter])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a rpcmessages.ListPhotosRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, rpcmessages.ListPhotosRequest):
            request = rpcmessages.ListPhotosRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if view is not None:
                request.view = view
            if filter is not None:
                request.filter = filter

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_photos]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__iter__` convenience method.
        response = pagers.ListPhotosPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def update_photo(self,
            request: Union[rpcmessages.UpdatePhotoRequest, dict] = None,
            *,
            photo: resources.Photo = None,
            update_mask: field_mask_pb2.FieldMask = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> resources.Photo:
        r"""Updates the metadata of a
        [Photo][google.streetview.publish.v1.Photo], such as pose, place
        association, connections, etc. Changing the pixels of a photo is
        not supported.

        Only the fields specified in the
        [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        field are used. If ``updateMask`` is not present, the update
        applies to all fields.

        This method returns the following error codes:

        -  [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED]
           if the requesting user did not create the requested photo.
        -  [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT]
           if the request is malformed.
        -  [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the
           requested photo does not exist.
        -  [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if
           the requested [Photo][google.streetview.publish.v1.Photo] is
           still being indexed.

        Args:
            request (Union[google.streetview.publish_v1.types.UpdatePhotoRequest, dict]):
                The request object. Request to update the metadata of a
                [Photo][google.streetview.publish.v1.Photo]. Updating
                the pixels of a photo is not supported.
            photo (google.streetview.publish_v1.types.Photo):
                Required. [Photo][google.streetview.publish.v1.Photo]
                object containing the new metadata.

                This corresponds to the ``photo`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            update_mask (google.protobuf.field_mask_pb2.FieldMask):
                Mask that identifies fields on the photo metadata to
                update. If not present, the old
                [Photo][google.streetview.publish.v1.Photo] metadata is
                entirely replaced with the new
                [Photo][google.streetview.publish.v1.Photo] metadata in
                this request. The update fails if invalid fields are
                specified. Multiple fields can be specified in a
                comma-delimited list.

                The following fields are valid:

                -  ``pose.heading``
                -  ``pose.latLngPair``
                -  ``pose.pitch``
                -  ``pose.roll``
                -  ``pose.level``
                -  ``pose.altitude``
                -  ``connections``
                -  ``places``

                .. raw:: html

                    <aside class="note"><b>Note:</b>  When
                    [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
                    contains repeated fields, the entire set of repeated values get replaced
                    with the new contents. For example, if
                    [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
                    contains `connections` and `UpdatePhotoRequest.photo.connections` is empty,
                    all connections are removed.</aside>

                This corresponds to the ``update_mask`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.streetview.publish_v1.types.Photo:
                Photo is used to store 360 photos
                along with photo metadata.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([photo, update_mask])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a rpcmessages.UpdatePhotoRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, rpcmessages.UpdatePhotoRequest):
            request = rpcmessages.UpdatePhotoRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if photo is not None:
                request.photo = photo
            if update_mask is not None:
                request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_photo]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def batch_update_photos(self,
            request: Union[rpcmessages.BatchUpdatePhotosRequest, dict] = None,
            *,
            update_photo_requests: Sequence[rpcmessages.UpdatePhotoRequest] = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> rpcmessages.BatchUpdatePhotosResponse:
        r"""Updates the metadata of
        [Photos][google.streetview.publish.v1.Photo], such as pose,
        place association, connections, etc. Changing the pixels of
        photos is not supported.

        Note that if
        [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        fails, either critical fields are missing or there is an
        authentication error. Even if
        [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        succeeds, individual photos in the batch may have failures.
        These failures are specified in each
        [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        in
        [BatchUpdatePhotosResponse.results][google.streetview.publish.v1.BatchUpdatePhotosResponse.results].
        See
        [UpdatePhoto][google.streetview.publish.v1.StreetViewPublishService.UpdatePhoto]
        for specific failures that can occur per photo.

        Only the fields specified in
        [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        field are used. If ``updateMask`` is not present, the update
        applies to all fields.

        The number of
        [UpdatePhotoRequest][google.streetview.publish.v1.UpdatePhotoRequest]
        messages in a
        [BatchUpdatePhotosRequest][google.streetview.publish.v1.BatchUpdatePhotosRequest]
        must not exceed 20.

        .. raw:: html

            <aside class="note"><b>Note:</b> To update
            [Pose.altitude][google.streetview.publish.v1.Pose.altitude],
            [Pose.latLngPair][google.streetview.publish.v1.Pose.lat_lng_pair] has to be
            filled as well. Otherwise, the request will fail.</aside>

        Args:
            request (Union[google.streetview.publish_v1.types.BatchUpdatePhotosRequest, dict]):
                The request object. Request to update the metadata of
                photos. Updating the pixels of photos is not supported.
            update_photo_requests (Sequence[google.streetview.publish_v1.types.UpdatePhotoRequest]):
                Required. List of
                [UpdatePhotoRequests][google.streetview.publish.v1.UpdatePhotoRequest].

                This corresponds to the ``update_photo_requests`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.streetview.publish_v1.types.BatchUpdatePhotosResponse:
                Response to batch update of metadata of one or more
                   [Photos][google.streetview.publish.v1.Photo].

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([update_photo_requests])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a rpcmessages.BatchUpdatePhotosRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, rpcmessages.BatchUpdatePhotosRequest):
            request = rpcmessages.BatchUpdatePhotosRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if update_photo_requests is not None:
                request.update_photo_requests = update_photo_requests

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.batch_update_photos]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def delete_photo(self,
            request: Union[rpcmessages.DeletePhotoRequest, dict] = None,
            *,
            photo_id: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Deletes a [Photo][google.streetview.publish.v1.Photo] and its
        metadata.

        This method returns the following error codes:

        -  [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED]
           if the requesting user did not create the requested photo.
        -  [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the
           photo ID does not exist.

        Args:
            request (Union[google.streetview.publish_v1.types.DeletePhotoRequest, dict]):
                The request object. Request to delete a
                [Photo][google.streetview.publish.v1.Photo].
            photo_id (str):
                Required. ID of the
                [Photo][google.streetview.publish.v1.Photo].

                This corresponds to the ``photo_id`` field
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
        has_flattened_params = any([photo_id])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a rpcmessages.DeletePhotoRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, rpcmessages.DeletePhotoRequest):
            request = rpcmessages.DeletePhotoRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if photo_id is not None:
                request.photo_id = photo_id

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete_photo]

        # Send the request.
        rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    def batch_delete_photos(self,
            request: Union[rpcmessages.BatchDeletePhotosRequest, dict] = None,
            *,
            photo_ids: Sequence[str] = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> rpcmessages.BatchDeletePhotosResponse:
        r"""Deletes a list of [Photos][google.streetview.publish.v1.Photo]
        and their metadata.

        Note that if
        [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        fails, either critical fields are missing or there was an
        authentication error. Even if
        [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        succeeds, individual photos in the batch may have failures.
        These failures are specified in each
        [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        in
        [BatchDeletePhotosResponse.results][google.streetview.publish.v1.BatchDeletePhotosResponse.status].
        See
        [DeletePhoto][google.streetview.publish.v1.StreetViewPublishService.DeletePhoto]
        for specific failures that can occur per photo.

        Args:
            request (Union[google.streetview.publish_v1.types.BatchDeletePhotosRequest, dict]):
                The request object. Request to delete multiple
                [Photos][google.streetview.publish.v1.Photo].
            photo_ids (Sequence[str]):
                Required. IDs of the
                [Photos][google.streetview.publish.v1.Photo]. HTTP GET
                requests require the following syntax for the URL query
                parameter: ``photoIds=<id1>&photoIds=<id2>&...``.

                This corresponds to the ``photo_ids`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.streetview.publish_v1.types.BatchDeletePhotosResponse:
                Response to batch delete of one or more
                   [Photos][google.streetview.publish.v1.Photo].

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([photo_ids])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a rpcmessages.BatchDeletePhotosRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, rpcmessages.BatchDeletePhotosRequest):
            request = rpcmessages.BatchDeletePhotosRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if photo_ids is not None:
                request.photo_ids = photo_ids

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.batch_delete_photos]

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
            "google-streetview-publish",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "StreetViewPublishServiceClient",
)
