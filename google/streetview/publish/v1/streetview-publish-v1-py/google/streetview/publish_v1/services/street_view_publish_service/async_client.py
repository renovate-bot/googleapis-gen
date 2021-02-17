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

from google.protobuf import empty_pb2 as empty  # type: ignore
from google.protobuf import field_mask_pb2 as field_mask  # type: ignore
from google.protobuf import timestamp_pb2 as timestamp  # type: ignore
from google.rpc import status_pb2 as status  # type: ignore
from google.streetview.publish_v1.services.street_view_publish_service import pagers
from google.streetview.publish_v1.types import resources
from google.streetview.publish_v1.types import rpcmessages

from .transports.base import StreetViewPublishServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import StreetViewPublishServiceGrpcAsyncIOTransport
from .client import StreetViewPublishServiceClient


class StreetViewPublishServiceAsyncClient:
    """Publishes and connects user-contributed photos on Street
    View.
    """

    _client: StreetViewPublishServiceClient

    DEFAULT_ENDPOINT = StreetViewPublishServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = StreetViewPublishServiceClient.DEFAULT_MTLS_ENDPOINT

    common_billing_account_path = staticmethod(StreetViewPublishServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(StreetViewPublishServiceClient.parse_common_billing_account_path)

    common_folder_path = staticmethod(StreetViewPublishServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(StreetViewPublishServiceClient.parse_common_folder_path)

    common_organization_path = staticmethod(StreetViewPublishServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(StreetViewPublishServiceClient.parse_common_organization_path)

    common_project_path = staticmethod(StreetViewPublishServiceClient.common_project_path)
    parse_common_project_path = staticmethod(StreetViewPublishServiceClient.parse_common_project_path)

    common_location_path = staticmethod(StreetViewPublishServiceClient.common_location_path)
    parse_common_location_path = staticmethod(StreetViewPublishServiceClient.parse_common_location_path)

    from_service_account_info = StreetViewPublishServiceClient.from_service_account_info
    from_service_account_file = StreetViewPublishServiceClient.from_service_account_file
    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> StreetViewPublishServiceTransport:
        """Return the transport used by the client instance.

        Returns:
            StreetViewPublishServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(StreetViewPublishServiceClient).get_transport_class, type(StreetViewPublishServiceClient))

    def __init__(self, *,
            credentials: credentials.Credentials = None,
            transport: Union[str, StreetViewPublishServiceTransport] = 'grpc_asyncio',
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiate the street view publish service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.StreetViewPublishServiceTransport]): The
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

        self._client = StreetViewPublishServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def start_upload(self,
            request: empty.Empty = None,
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
            request (:class:`google.protobuf.empty_pb2.Empty`):
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

        # The request isn't a proto-plus wrapped type,
        # so it must be constructed via keyword expansion.
        if isinstance(request, dict):
            request = empty.Empty(**request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.start_upload,
            default_retry=retries.Retry(
                initial=0.1,
                maximum=60.0,
                multiplier=1.3,
                predicate=retries.if_exception_type(
                ),
            ),
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

        # Done; return the response.
        return response

    async def create_photo(self,
            request: rpcmessages.CreatePhotoRequest = None,
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
            request (:class:`google.streetview.publish_v1.types.CreatePhotoRequest`):
                The request object. Request to create a
                [Photo][google.streetview.publish.v1.Photo].
            photo (:class:`google.streetview.publish_v1.types.Photo`):
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

        request = rpcmessages.CreatePhotoRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if photo is not None:
            request.photo = photo

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_photo,
            default_retry=retries.Retry(
                initial=0.1,
                maximum=60.0,
                multiplier=1.3,
                predicate=retries.if_exception_type(
                ),
            ),
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

        # Done; return the response.
        return response

    async def get_photo(self,
            request: rpcmessages.GetPhotoRequest = None,
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
            request (:class:`google.streetview.publish_v1.types.GetPhotoRequest`):
                The request object. Request to get a
                [Photo][google.streetview.publish.v1.Photo].
                By default

                * does not return the download URL for the photo bytes.
                Parameters:

                * `view` controls if the download URL for the photo
                bytes is returned.
            photo_id (:class:`str`):
                Required. ID of the
                [Photo][google.streetview.publish.v1.Photo].

                This corresponds to the ``photo_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            view (:class:`google.streetview.publish_v1.types.PhotoView`):
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

        request = rpcmessages.GetPhotoRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if photo_id is not None:
            request.photo_id = photo_id
        if view is not None:
            request.view = view

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_photo,
            default_retry=retries.Retry(
                initial=0.1,
                maximum=60.0,
                multiplier=1.3,
                predicate=retries.if_exception_type(
                    exceptions.DeadlineExceeded,
                    exceptions.ServiceUnavailable,
                ),
            ),
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

        # Done; return the response.
        return response

    async def batch_get_photos(self,
            request: rpcmessages.BatchGetPhotosRequest = None,
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
            request (:class:`google.streetview.publish_v1.types.BatchGetPhotosRequest`):
                The request object. Request to get one or more
                [Photos][google.streetview.publish.v1.Photo]. By default
                * does not return the download URL for the photo bytes.
                Parameters:

                * `view` controls if the download URL for the photo
                bytes is returned.
            photo_ids (:class:`Sequence[str]`):
                Required. IDs of the
                [Photos][google.streetview.publish.v1.Photo]. HTTP GET
                requests require the following syntax for the URL query
                parameter: ``photoIds=<id1>&photoIds=<id2>&...``.

                This corresponds to the ``photo_ids`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            view (:class:`google.streetview.publish_v1.types.PhotoView`):
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

        request = rpcmessages.BatchGetPhotosRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if view is not None:
            request.view = view

        if photo_ids:
            request.photo_ids.extend(photo_ids)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.batch_get_photos,
            default_retry=retries.Retry(
                initial=0.1,
                maximum=60.0,
                multiplier=1.3,
                predicate=retries.if_exception_type(
                    exceptions.DeadlineExceeded,
                    exceptions.ServiceUnavailable,
                ),
            ),
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

        # Done; return the response.
        return response

    async def list_photos(self,
            request: rpcmessages.ListPhotosRequest = None,
            *,
            view: rpcmessages.PhotoView = None,
            filter: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListPhotosAsyncPager:
        r"""Lists all the [Photos][google.streetview.publish.v1.Photo] that
        belong to the user.

        .. raw:: html

            <aside class="note"><b>Note:</b> Recently created photos that are still
            being indexed are not returned in the response.</aside>

        Args:
            request (:class:`google.streetview.publish_v1.types.ListPhotosRequest`):
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
            view (:class:`google.streetview.publish_v1.types.PhotoView`):
                Specifies if a download URL for the
                photos bytes should be returned in the
                Photos response.

                This corresponds to the ``view`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            filter (:class:`str`):
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
            google.streetview.publish_v1.services.street_view_publish_service.pagers.ListPhotosAsyncPager:
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

        request = rpcmessages.ListPhotosRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if view is not None:
            request.view = view
        if filter is not None:
            request.filter = filter

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_photos,
            default_retry=retries.Retry(
                initial=0.1,
                maximum=60.0,
                multiplier=1.3,
                predicate=retries.if_exception_type(
                    exceptions.DeadlineExceeded,
                    exceptions.ServiceUnavailable,
                ),
            ),
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
        response = pagers.ListPhotosAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def update_photo(self,
            request: rpcmessages.UpdatePhotoRequest = None,
            *,
            photo: resources.Photo = None,
            update_mask: field_mask.FieldMask = None,
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
            request (:class:`google.streetview.publish_v1.types.UpdatePhotoRequest`):
                The request object. Request to update the metadata of a
                [Photo][google.streetview.publish.v1.Photo]. Updating
                the pixels of a photo is not supported.
            photo (:class:`google.streetview.publish_v1.types.Photo`):
                Required. [Photo][google.streetview.publish.v1.Photo]
                object containing the new metadata.

                This corresponds to the ``photo`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            update_mask (:class:`google.protobuf.field_mask_pb2.FieldMask`):
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

        request = rpcmessages.UpdatePhotoRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if photo is not None:
            request.photo = photo
        if update_mask is not None:
            request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_photo,
            default_retry=retries.Retry(
                initial=0.1,
                maximum=60.0,
                multiplier=1.3,
                predicate=retries.if_exception_type(
                    exceptions.DeadlineExceeded,
                    exceptions.ServiceUnavailable,
                ),
            ),
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

        # Done; return the response.
        return response

    async def batch_update_photos(self,
            request: rpcmessages.BatchUpdatePhotosRequest = None,
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
            request (:class:`google.streetview.publish_v1.types.BatchUpdatePhotosRequest`):
                The request object. Request to update the metadata of
                photos. Updating the pixels of photos is not supported.
            update_photo_requests (:class:`Sequence[google.streetview.publish_v1.types.UpdatePhotoRequest]`):
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

        request = rpcmessages.BatchUpdatePhotosRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if update_photo_requests:
            request.update_photo_requests.extend(update_photo_requests)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.batch_update_photos,
            default_retry=retries.Retry(
                initial=0.1,
                maximum=60.0,
                multiplier=1.3,
                predicate=retries.if_exception_type(
                ),
            ),
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

        # Done; return the response.
        return response

    async def delete_photo(self,
            request: rpcmessages.DeletePhotoRequest = None,
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
            request (:class:`google.streetview.publish_v1.types.DeletePhotoRequest`):
                The request object. Request to delete a
                [Photo][google.streetview.publish.v1.Photo].
            photo_id (:class:`str`):
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

        request = rpcmessages.DeletePhotoRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if photo_id is not None:
            request.photo_id = photo_id

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_photo,
            default_retry=retries.Retry(
                initial=0.1,
                maximum=60.0,
                multiplier=1.3,
                predicate=retries.if_exception_type(
                    exceptions.DeadlineExceeded,
                    exceptions.ServiceUnavailable,
                ),
            ),
            default_timeout=60.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Send the request.
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    async def batch_delete_photos(self,
            request: rpcmessages.BatchDeletePhotosRequest = None,
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
            request (:class:`google.streetview.publish_v1.types.BatchDeletePhotosRequest`):
                The request object. Request to delete multiple
                [Photos][google.streetview.publish.v1.Photo].
            photo_ids (:class:`Sequence[str]`):
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

        request = rpcmessages.BatchDeletePhotosRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if photo_ids:
            request.photo_ids.extend(photo_ids)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.batch_delete_photos,
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
            'google-streetview-publish',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    'StreetViewPublishServiceAsyncClient',
)
