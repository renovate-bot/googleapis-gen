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
from typing import Awaitable, Callable, Dict, Optional, Sequence, Tuple, Union

from google.api_core import gapic_v1                   # type: ignore
from google.api_core import grpc_helpers_async         # type: ignore
from google.auth import credentials as ga_credentials   # type: ignore
from google.auth.transport.grpc import SslCredentials  # type: ignore
import packaging.version

import grpc                        # type: ignore
from grpc.experimental import aio  # type: ignore

from google.example.library_v1.types import library
from google.protobuf import empty_pb2  # type: ignore
from .base import LibraryServiceTransport, DEFAULT_CLIENT_INFO
from .grpc import LibraryServiceGrpcTransport


class LibraryServiceGrpcAsyncIOTransport(LibraryServiceTransport):
    """gRPC AsyncIO backend transport for LibraryService.

    This API represents a simple digital library. It lets you manage
    Shelf resources and Book resources in the library. It defines the
    following resource model:

    -  The API has a collection of
       [Shelf][google.example.library.v1.Shelf] resources, named
       ``shelves/*``

    -  Each Shelf has a collection of
       [Book][google.example.library.v1.Book] resources, named
       ``shelves/*/books/*``

    This class defines the same methods as the primary client, so the
    primary client can load the underlying transport implementation
    and call it.

    It sends protocol buffers over the wire using gRPC (which is built on
    top of HTTP/2); the ``grpcio`` package must be installed.
    """

    _grpc_channel: aio.Channel
    _stubs: Dict[str, Callable] = {}

    @classmethod
    def create_channel(cls,
                       host: str = 'library-example.googleapis.com',
                       credentials: ga_credentials.Credentials = None,
                       credentials_file: Optional[str] = None,
                       scopes: Optional[Sequence[str]] = None,
                       quota_project_id: Optional[str] = None,
                       **kwargs) -> aio.Channel:
        """Create and return a gRPC AsyncIO channel object.
        Args:
            host (Optional[str]): The host for the channel to use.
            credentials (Optional[~.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify this application to the service. If
                none are specified, the client will attempt to ascertain
                the credentials from the environment.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is ignored if ``channel`` is provided.
            scopes (Optional[Sequence[str]]): A optional list of scopes needed for this
                service. These are only used when credentials are not specified and
                are passed to :func:`google.auth.default`.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            kwargs (Optional[dict]): Keyword arguments, which are passed to the
                channel creation.
        Returns:
            aio.Channel: A gRPC AsyncIO channel object.
        """

        return grpc_helpers_async.create_channel(
            host,
            credentials=credentials,
            credentials_file=credentials_file,
            quota_project_id=quota_project_id,
            default_scopes=cls.AUTH_SCOPES,
            scopes=scopes,
            default_host=cls.DEFAULT_HOST,
            **kwargs
        )

    def __init__(self, *,
            host: str = 'library-example.googleapis.com',
            credentials: ga_credentials.Credentials = None,
            credentials_file: Optional[str] = None,
            scopes: Optional[Sequence[str]] = None,
            channel: aio.Channel = None,
            api_mtls_endpoint: str = None,
            client_cert_source: Callable[[], Tuple[bytes, bytes]] = None,
            ssl_channel_credentials: grpc.ChannelCredentials = None,
            client_cert_source_for_mtls: Callable[[], Tuple[bytes, bytes]] = None,
            quota_project_id=None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            always_use_jwt_access: Optional[bool] = False,
            ) -> None:
        """Instantiate the transport.

        Args:
            host (Optional[str]):
                 The hostname to connect to.
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
                This argument is ignored if ``channel`` is provided.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is ignored if ``channel`` is provided.
            scopes (Optional[Sequence[str]]): A optional list of scopes needed for this
                service. These are only used when credentials are not specified and
                are passed to :func:`google.auth.default`.
            channel (Optional[aio.Channel]): A ``Channel`` instance through
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
            always_use_jwt_access (Optional[bool]): Whether self signed JWT should
                be used for service account credentials.

        Raises:
            google.auth.exceptions.MutualTlsChannelError: If mutual TLS transport
              creation failed for any reason.
          google.api_core.exceptions.DuplicateCredentialArgs: If both ``credentials``
              and ``credentials_file`` are passed.
        """
        self._grpc_channel = None
        self._ssl_channel_credentials = ssl_channel_credentials
        self._stubs: Dict[str, Callable] = {}

        if api_mtls_endpoint:
            warnings.warn("api_mtls_endpoint is deprecated", DeprecationWarning)
        if client_cert_source:
            warnings.warn("client_cert_source is deprecated", DeprecationWarning)

        if channel:
            # Ignore credentials if a channel was passed.
            credentials = False
            # If a channel was explicitly provided, set it.
            self._grpc_channel = channel
            self._ssl_channel_credentials = None
        else:
            if api_mtls_endpoint:
                host = api_mtls_endpoint

                # Create SSL credentials with client_cert_source or application
                # default SSL credentials.
                if client_cert_source:
                    cert, key = client_cert_source()
                    self._ssl_channel_credentials = grpc.ssl_channel_credentials(
                        certificate_chain=cert, private_key=key
                    )
                else:
                    self._ssl_channel_credentials = SslCredentials().ssl_credentials

            else:
                if client_cert_source_for_mtls and not ssl_channel_credentials:
                    cert, key = client_cert_source_for_mtls()
                    self._ssl_channel_credentials = grpc.ssl_channel_credentials(
                        certificate_chain=cert, private_key=key
                    )

        # The base transport sets the host, credentials and scopes
        super().__init__(
            host=host,
            credentials=credentials,
            credentials_file=credentials_file,
            scopes=scopes,
            quota_project_id=quota_project_id,
            client_info=client_info,
            always_use_jwt_access=always_use_jwt_access,
        )

        if not self._grpc_channel:
            self._grpc_channel = type(self).create_channel(
                self._host,
                credentials=self._credentials,
                credentials_file=credentials_file,
                scopes=self._scopes,
                ssl_credentials=self._ssl_channel_credentials,
                quota_project_id=quota_project_id,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )

        # Wrap messages. This must be done after self._grpc_channel exists
        self._prep_wrapped_messages(client_info)

    @property
    def grpc_channel(self) -> aio.Channel:
        """Create the channel designed to connect to this service.

        This property caches on the instance; repeated calls return
        the same channel.
        """
        # Return the channel from cache.
        return self._grpc_channel

    @property
    def create_shelf(self) -> Callable[
            [library.CreateShelfRequest],
            Awaitable[library.Shelf]]:
        r"""Return a callable for the create shelf method over gRPC.

        Creates a shelf, and returns the new Shelf.

        Returns:
            Callable[[~.CreateShelfRequest],
                    Awaitable[~.Shelf]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_shelf' not in self._stubs:
            self._stubs['create_shelf'] = self.grpc_channel.unary_unary(
                '/google.example.library.v1.LibraryService/CreateShelf',
                request_serializer=library.CreateShelfRequest.serialize,
                response_deserializer=library.Shelf.deserialize,
            )
        return self._stubs['create_shelf']

    @property
    def get_shelf(self) -> Callable[
            [library.GetShelfRequest],
            Awaitable[library.Shelf]]:
        r"""Return a callable for the get shelf method over gRPC.

        Gets a shelf. Returns NOT_FOUND if the shelf does not exist.

        Returns:
            Callable[[~.GetShelfRequest],
                    Awaitable[~.Shelf]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_shelf' not in self._stubs:
            self._stubs['get_shelf'] = self.grpc_channel.unary_unary(
                '/google.example.library.v1.LibraryService/GetShelf',
                request_serializer=library.GetShelfRequest.serialize,
                response_deserializer=library.Shelf.deserialize,
            )
        return self._stubs['get_shelf']

    @property
    def list_shelves(self) -> Callable[
            [library.ListShelvesRequest],
            Awaitable[library.ListShelvesResponse]]:
        r"""Return a callable for the list shelves method over gRPC.

        Lists shelves. The order is unspecified but
        deterministic. Newly created shelves will not
        necessarily be added to the end of this list.

        Returns:
            Callable[[~.ListShelvesRequest],
                    Awaitable[~.ListShelvesResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_shelves' not in self._stubs:
            self._stubs['list_shelves'] = self.grpc_channel.unary_unary(
                '/google.example.library.v1.LibraryService/ListShelves',
                request_serializer=library.ListShelvesRequest.serialize,
                response_deserializer=library.ListShelvesResponse.deserialize,
            )
        return self._stubs['list_shelves']

    @property
    def delete_shelf(self) -> Callable[
            [library.DeleteShelfRequest],
            Awaitable[empty_pb2.Empty]]:
        r"""Return a callable for the delete shelf method over gRPC.

        Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.

        Returns:
            Callable[[~.DeleteShelfRequest],
                    Awaitable[~.Empty]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_shelf' not in self._stubs:
            self._stubs['delete_shelf'] = self.grpc_channel.unary_unary(
                '/google.example.library.v1.LibraryService/DeleteShelf',
                request_serializer=library.DeleteShelfRequest.serialize,
                response_deserializer=empty_pb2.Empty.FromString,
            )
        return self._stubs['delete_shelf']

    @property
    def merge_shelves(self) -> Callable[
            [library.MergeShelvesRequest],
            Awaitable[library.Shelf]]:
        r"""Return a callable for the merge shelves method over gRPC.

        Merges two shelves by adding all books from the shelf named
        ``other_shelf_name`` to shelf ``name``, and deletes
        ``other_shelf_name``. Returns the updated shelf. The book ids of
        the moved books may not be the same as the original books.

        Returns NOT_FOUND if either shelf does not exist. This call is a
        no-op if the specified shelves are the same.

        Returns:
            Callable[[~.MergeShelvesRequest],
                    Awaitable[~.Shelf]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'merge_shelves' not in self._stubs:
            self._stubs['merge_shelves'] = self.grpc_channel.unary_unary(
                '/google.example.library.v1.LibraryService/MergeShelves',
                request_serializer=library.MergeShelvesRequest.serialize,
                response_deserializer=library.Shelf.deserialize,
            )
        return self._stubs['merge_shelves']

    @property
    def create_book(self) -> Callable[
            [library.CreateBookRequest],
            Awaitable[library.Book]]:
        r"""Return a callable for the create book method over gRPC.

        Creates a book, and returns the new Book.

        Returns:
            Callable[[~.CreateBookRequest],
                    Awaitable[~.Book]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_book' not in self._stubs:
            self._stubs['create_book'] = self.grpc_channel.unary_unary(
                '/google.example.library.v1.LibraryService/CreateBook',
                request_serializer=library.CreateBookRequest.serialize,
                response_deserializer=library.Book.deserialize,
            )
        return self._stubs['create_book']

    @property
    def get_book(self) -> Callable[
            [library.GetBookRequest],
            Awaitable[library.Book]]:
        r"""Return a callable for the get book method over gRPC.

        Gets a book. Returns NOT_FOUND if the book does not exist.

        Returns:
            Callable[[~.GetBookRequest],
                    Awaitable[~.Book]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_book' not in self._stubs:
            self._stubs['get_book'] = self.grpc_channel.unary_unary(
                '/google.example.library.v1.LibraryService/GetBook',
                request_serializer=library.GetBookRequest.serialize,
                response_deserializer=library.Book.deserialize,
            )
        return self._stubs['get_book']

    @property
    def list_books(self) -> Callable[
            [library.ListBooksRequest],
            Awaitable[library.ListBooksResponse]]:
        r"""Return a callable for the list books method over gRPC.

        Lists books in a shelf. The order is unspecified but
        deterministic. Newly created books will not necessarily be added
        to the end of this list. Returns NOT_FOUND if the shelf does not
        exist.

        Returns:
            Callable[[~.ListBooksRequest],
                    Awaitable[~.ListBooksResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_books' not in self._stubs:
            self._stubs['list_books'] = self.grpc_channel.unary_unary(
                '/google.example.library.v1.LibraryService/ListBooks',
                request_serializer=library.ListBooksRequest.serialize,
                response_deserializer=library.ListBooksResponse.deserialize,
            )
        return self._stubs['list_books']

    @property
    def delete_book(self) -> Callable[
            [library.DeleteBookRequest],
            Awaitable[empty_pb2.Empty]]:
        r"""Return a callable for the delete book method over gRPC.

        Deletes a book. Returns NOT_FOUND if the book does not exist.

        Returns:
            Callable[[~.DeleteBookRequest],
                    Awaitable[~.Empty]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_book' not in self._stubs:
            self._stubs['delete_book'] = self.grpc_channel.unary_unary(
                '/google.example.library.v1.LibraryService/DeleteBook',
                request_serializer=library.DeleteBookRequest.serialize,
                response_deserializer=empty_pb2.Empty.FromString,
            )
        return self._stubs['delete_book']

    @property
    def update_book(self) -> Callable[
            [library.UpdateBookRequest],
            Awaitable[library.Book]]:
        r"""Return a callable for the update book method over gRPC.

        Updates a book. Returns INVALID_ARGUMENT if the name of the book
        is non-empty and does not equal the existing name.

        Returns:
            Callable[[~.UpdateBookRequest],
                    Awaitable[~.Book]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_book' not in self._stubs:
            self._stubs['update_book'] = self.grpc_channel.unary_unary(
                '/google.example.library.v1.LibraryService/UpdateBook',
                request_serializer=library.UpdateBookRequest.serialize,
                response_deserializer=library.Book.deserialize,
            )
        return self._stubs['update_book']

    @property
    def move_book(self) -> Callable[
            [library.MoveBookRequest],
            Awaitable[library.Book]]:
        r"""Return a callable for the move book method over gRPC.

        Moves a book to another shelf, and returns the new
        book. The book id of the new book may not be the same as
        the original book.

        Returns:
            Callable[[~.MoveBookRequest],
                    Awaitable[~.Book]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'move_book' not in self._stubs:
            self._stubs['move_book'] = self.grpc_channel.unary_unary(
                '/google.example.library.v1.LibraryService/MoveBook',
                request_serializer=library.MoveBookRequest.serialize,
                response_deserializer=library.Book.deserialize,
            )
        return self._stubs['move_book']


__all__ = (
    'LibraryServiceGrpcAsyncIOTransport',
)
