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

import warnings
from typing import Callable, Dict, Optional, Sequence, Tuple

from google.api_core import grpc_helpers   # type: ignore
from google.api_core import gapic_v1       # type: ignore
from google import auth                    # type: ignore
from google.auth import credentials        # type: ignore
from google.auth.transport.grpc import SslCredentials  # type: ignore

import grpc  # type: ignore

from google.protobuf import empty_pb2 as empty  # type: ignore
from google.streetview.publish_v1.types import resources
from google.streetview.publish_v1.types import rpcmessages

from .base import StreetViewPublishServiceTransport, DEFAULT_CLIENT_INFO


class StreetViewPublishServiceGrpcTransport(StreetViewPublishServiceTransport):
    """gRPC backend transport for StreetViewPublishService.

    Publishes and connects user-contributed photos on Street
    View.

    This class defines the same methods as the primary client, so the
    primary client can load the underlying transport implementation
    and call it.

    It sends protocol buffers over the wire using gRPC (which is built on
    top of HTTP/2); the ``grpcio`` package must be installed.
    """
    _stubs: Dict[str, Callable]

    def __init__(self, *,
            host: str = 'streetviewpublish.googleapis.com',
            credentials: credentials.Credentials = None,
            credentials_file: str = None,
            scopes: Sequence[str] = None,
            channel: grpc.Channel = None,
            api_mtls_endpoint: str = None,
            client_cert_source: Callable[[], Tuple[bytes, bytes]] = None,
            ssl_channel_credentials: grpc.ChannelCredentials = None,
            client_cert_source_for_mtls: Callable[[], Tuple[bytes, bytes]] = None,
            quota_project_id: Optional[str] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiate the transport.

        Args:
            host (Optional[str]): The hostname to connect to.
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
                This argument is ignored if ``channel`` is provided.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is ignored if ``channel`` is provided.
            scopes (Optional(Sequence[str])): A list of scopes. This argument is
                ignored if ``channel`` is provided.
            channel (Optional[grpc.Channel]): A ``Channel`` instance through
                which to make calls.
            api_mtls_endpoint (Optional[str]): Deprecated. The mutual TLS endpoint.
                If provided, it overrides the ``host`` argument and tries to create
                a mutual TLS channel with client SSL credentials from
                ``client_cert_source`` or applicatin default SSL credentials.
            client_cert_source (Optional[Callable[[], Tuple[bytes, bytes]]]):
                Deprecated. A callback to provide client SSL certificate bytes and
                private key bytes, both in PEM format. It is ignored if
                ``api_mtls_endpoint`` is None.
            ssl_channel_credentials (grpc.ChannelCredentials): SSL credentials
                for grpc channel. It is ignored if ``channel`` is provided.
            client_cert_source_for_mtls (Optional[Callable[[], Tuple[bytes, bytes]]]):
                A callback to provide client certificate bytes and private key bytes,
                both in PEM format. It is used to configure mutual TLS channel. It is
                ignored if ``channel`` or ``ssl_channel_credentials`` is provided.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):
                The client info used to send a user-agent string along with
                API requests. If ``None``, then default info will be used.
                Generally, you only need to set this if you're developing
                your own client library.

        Raises:
          google.auth.exceptions.MutualTLSChannelError: If mutual TLS transport
              creation failed for any reason.
          google.api_core.exceptions.DuplicateCredentialArgs: If both ``credentials``
              and ``credentials_file`` are passed.
        """
        self._ssl_channel_credentials = ssl_channel_credentials

        if api_mtls_endpoint:
            warnings.warn("api_mtls_endpoint is deprecated", DeprecationWarning)
        if client_cert_source:
            warnings.warn("client_cert_source is deprecated", DeprecationWarning)

        if channel:
            # Sanity check: Ensure that channel and credentials are not both
            # provided.
            credentials = False

            # If a channel was explicitly provided, set it.
            self._grpc_channel = channel
            self._ssl_channel_credentials = None
        elif api_mtls_endpoint:
            host = api_mtls_endpoint if ":" in api_mtls_endpoint else api_mtls_endpoint + ":443"

            if credentials is None:
                credentials, _ = auth.default(scopes=self.AUTH_SCOPES, quota_project_id=quota_project_id)

            # Create SSL credentials with client_cert_source or application
            # default SSL credentials.
            if client_cert_source:
                cert, key = client_cert_source()
                ssl_credentials = grpc.ssl_channel_credentials(
                    certificate_chain=cert, private_key=key
                )
            else:
                ssl_credentials = SslCredentials().ssl_credentials

            # create a new channel. The provided one is ignored.
            self._grpc_channel = type(self).create_channel(
                host,
                credentials=credentials,
                credentials_file=credentials_file,
                ssl_credentials=ssl_credentials,
                scopes=scopes or self.AUTH_SCOPES,
                quota_project_id=quota_project_id,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )
            self._ssl_channel_credentials = ssl_credentials
        else:
            host = host if ":" in host else host + ":443"

            if credentials is None:
                credentials, _ = auth.default(scopes=self.AUTH_SCOPES, quota_project_id=quota_project_id)

            if client_cert_source_for_mtls and not ssl_channel_credentials:
                cert, key = client_cert_source_for_mtls()
                self._ssl_channel_credentials = grpc.ssl_channel_credentials(
                    certificate_chain=cert, private_key=key
                )

            # create a new channel. The provided one is ignored.
            self._grpc_channel = type(self).create_channel(
                host,
                credentials=credentials,
                credentials_file=credentials_file,
                ssl_credentials=self._ssl_channel_credentials,
                scopes=scopes or self.AUTH_SCOPES,
                quota_project_id=quota_project_id,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )

        self._stubs = {}  # type: Dict[str, Callable]

        # Run the base constructor.
        super().__init__(
            host=host,
            credentials=credentials,
            credentials_file=credentials_file,
            scopes=scopes or self.AUTH_SCOPES,
            quota_project_id=quota_project_id,
            client_info=client_info,
        )

    @classmethod
    def create_channel(cls,
                       host: str = 'streetviewpublish.googleapis.com',
                       credentials: credentials.Credentials = None,
                       credentials_file: str = None,
                       scopes: Optional[Sequence[str]] = None,
                       quota_project_id: Optional[str] = None,
                       **kwargs) -> grpc.Channel:
        """Create and return a gRPC channel object.
        Args:
            address (Optional[str]): The host for the channel to use.
            credentials (Optional[~.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify this application to the service. If
                none are specified, the client will attempt to ascertain
                the credentials from the environment.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is mutually exclusive with credentials.
            scopes (Optional[Sequence[str]]): A optional list of scopes needed for this
                service. These are only used when credentials are not specified and
                are passed to :func:`google.auth.default`.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            kwargs (Optional[dict]): Keyword arguments, which are passed to the
                channel creation.
        Returns:
            grpc.Channel: A gRPC channel object.

        Raises:
            google.api_core.exceptions.DuplicateCredentialArgs: If both ``credentials``
              and ``credentials_file`` are passed.
        """
        scopes = scopes or cls.AUTH_SCOPES
        return grpc_helpers.create_channel(
            host,
            credentials=credentials,
            credentials_file=credentials_file,
            scopes=scopes,
            quota_project_id=quota_project_id,
            **kwargs
        )

    @property
    def grpc_channel(self) -> grpc.Channel:
        """Return the channel designed to connect to this service.
        """
        return self._grpc_channel

    @property
    def start_upload(self) -> Callable[
            [empty.Empty],
            resources.UploadRef]:
        r"""Return a callable for the start upload method over gRPC.

        Creates an upload session to start uploading photo bytes. The
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

        Returns:
            Callable[[~.Empty],
                    ~.UploadRef]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'start_upload' not in self._stubs:
            self._stubs['start_upload'] = self.grpc_channel.unary_unary(
                '/google.streetview.publish.v1.StreetViewPublishService/StartUpload',
                request_serializer=empty.Empty.SerializeToString,
                response_deserializer=resources.UploadRef.deserialize,
            )
        return self._stubs['start_upload']

    @property
    def create_photo(self) -> Callable[
            [rpcmessages.CreatePhotoRequest],
            resources.Photo]:
        r"""Return a callable for the create photo method over gRPC.

        After the client finishes uploading the photo with the returned
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

        Returns:
            Callable[[~.CreatePhotoRequest],
                    ~.Photo]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_photo' not in self._stubs:
            self._stubs['create_photo'] = self.grpc_channel.unary_unary(
                '/google.streetview.publish.v1.StreetViewPublishService/CreatePhoto',
                request_serializer=rpcmessages.CreatePhotoRequest.serialize,
                response_deserializer=resources.Photo.deserialize,
            )
        return self._stubs['create_photo']

    @property
    def get_photo(self) -> Callable[
            [rpcmessages.GetPhotoRequest],
            resources.Photo]:
        r"""Return a callable for the get photo method over gRPC.

        Gets the metadata of the specified
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

        Returns:
            Callable[[~.GetPhotoRequest],
                    ~.Photo]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_photo' not in self._stubs:
            self._stubs['get_photo'] = self.grpc_channel.unary_unary(
                '/google.streetview.publish.v1.StreetViewPublishService/GetPhoto',
                request_serializer=rpcmessages.GetPhotoRequest.serialize,
                response_deserializer=resources.Photo.deserialize,
            )
        return self._stubs['get_photo']

    @property
    def batch_get_photos(self) -> Callable[
            [rpcmessages.BatchGetPhotosRequest],
            rpcmessages.BatchGetPhotosResponse]:
        r"""Return a callable for the batch get photos method over gRPC.

        Gets the metadata of the specified
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

        Returns:
            Callable[[~.BatchGetPhotosRequest],
                    ~.BatchGetPhotosResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'batch_get_photos' not in self._stubs:
            self._stubs['batch_get_photos'] = self.grpc_channel.unary_unary(
                '/google.streetview.publish.v1.StreetViewPublishService/BatchGetPhotos',
                request_serializer=rpcmessages.BatchGetPhotosRequest.serialize,
                response_deserializer=rpcmessages.BatchGetPhotosResponse.deserialize,
            )
        return self._stubs['batch_get_photos']

    @property
    def list_photos(self) -> Callable[
            [rpcmessages.ListPhotosRequest],
            rpcmessages.ListPhotosResponse]:
        r"""Return a callable for the list photos method over gRPC.

        Lists all the [Photos][google.streetview.publish.v1.Photo] that
        belong to the user.

        .. raw:: html

            <aside class="note"><b>Note:</b> Recently created photos that are still
            being indexed are not returned in the response.</aside>

        Returns:
            Callable[[~.ListPhotosRequest],
                    ~.ListPhotosResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_photos' not in self._stubs:
            self._stubs['list_photos'] = self.grpc_channel.unary_unary(
                '/google.streetview.publish.v1.StreetViewPublishService/ListPhotos',
                request_serializer=rpcmessages.ListPhotosRequest.serialize,
                response_deserializer=rpcmessages.ListPhotosResponse.deserialize,
            )
        return self._stubs['list_photos']

    @property
    def update_photo(self) -> Callable[
            [rpcmessages.UpdatePhotoRequest],
            resources.Photo]:
        r"""Return a callable for the update photo method over gRPC.

        Updates the metadata of a
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

        Returns:
            Callable[[~.UpdatePhotoRequest],
                    ~.Photo]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_photo' not in self._stubs:
            self._stubs['update_photo'] = self.grpc_channel.unary_unary(
                '/google.streetview.publish.v1.StreetViewPublishService/UpdatePhoto',
                request_serializer=rpcmessages.UpdatePhotoRequest.serialize,
                response_deserializer=resources.Photo.deserialize,
            )
        return self._stubs['update_photo']

    @property
    def batch_update_photos(self) -> Callable[
            [rpcmessages.BatchUpdatePhotosRequest],
            rpcmessages.BatchUpdatePhotosResponse]:
        r"""Return a callable for the batch update photos method over gRPC.

        Updates the metadata of
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

        Returns:
            Callable[[~.BatchUpdatePhotosRequest],
                    ~.BatchUpdatePhotosResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'batch_update_photos' not in self._stubs:
            self._stubs['batch_update_photos'] = self.grpc_channel.unary_unary(
                '/google.streetview.publish.v1.StreetViewPublishService/BatchUpdatePhotos',
                request_serializer=rpcmessages.BatchUpdatePhotosRequest.serialize,
                response_deserializer=rpcmessages.BatchUpdatePhotosResponse.deserialize,
            )
        return self._stubs['batch_update_photos']

    @property
    def delete_photo(self) -> Callable[
            [rpcmessages.DeletePhotoRequest],
            empty.Empty]:
        r"""Return a callable for the delete photo method over gRPC.

        Deletes a [Photo][google.streetview.publish.v1.Photo] and its
        metadata.

        This method returns the following error codes:

        -  [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED]
           if the requesting user did not create the requested photo.
        -  [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the
           photo ID does not exist.

        Returns:
            Callable[[~.DeletePhotoRequest],
                    ~.Empty]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_photo' not in self._stubs:
            self._stubs['delete_photo'] = self.grpc_channel.unary_unary(
                '/google.streetview.publish.v1.StreetViewPublishService/DeletePhoto',
                request_serializer=rpcmessages.DeletePhotoRequest.serialize,
                response_deserializer=empty.Empty.FromString,
            )
        return self._stubs['delete_photo']

    @property
    def batch_delete_photos(self) -> Callable[
            [rpcmessages.BatchDeletePhotosRequest],
            rpcmessages.BatchDeletePhotosResponse]:
        r"""Return a callable for the batch delete photos method over gRPC.

        Deletes a list of [Photos][google.streetview.publish.v1.Photo]
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

        Returns:
            Callable[[~.BatchDeletePhotosRequest],
                    ~.BatchDeletePhotosResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'batch_delete_photos' not in self._stubs:
            self._stubs['batch_delete_photos'] = self.grpc_channel.unary_unary(
                '/google.streetview.publish.v1.StreetViewPublishService/BatchDeletePhotos',
                request_serializer=rpcmessages.BatchDeletePhotosRequest.serialize,
                response_deserializer=rpcmessages.BatchDeletePhotosResponse.deserialize,
            )
        return self._stubs['batch_delete_photos']


__all__ = (
    'StreetViewPublishServiceGrpcTransport',
)