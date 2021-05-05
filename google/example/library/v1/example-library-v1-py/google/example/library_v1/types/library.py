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
import proto  # type: ignore

from google.protobuf import field_mask_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.example.library.v1',
    manifest={
        'Book',
        'Shelf',
        'CreateShelfRequest',
        'GetShelfRequest',
        'ListShelvesRequest',
        'ListShelvesResponse',
        'DeleteShelfRequest',
        'MergeShelvesRequest',
        'CreateBookRequest',
        'GetBookRequest',
        'ListBooksRequest',
        'ListBooksResponse',
        'UpdateBookRequest',
        'DeleteBookRequest',
        'MoveBookRequest',
    },
)


class Book(proto.Message):
    r"""A single book in the library.
    Attributes:
        name (str):
            The resource name of the book. Book names have the form
            ``shelves/{shelf_id}/books/{book_id}``. The name is ignored
            when creating a book.
        author (str):
            The name of the book author.
        title (str):
            The title of the book.
        read (bool):
            Value indicating whether the book has been
            read.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    author = proto.Field(
        proto.STRING,
        number=2,
    )
    title = proto.Field(
        proto.STRING,
        number=3,
    )
    read = proto.Field(
        proto.BOOL,
        number=4,
    )


class Shelf(proto.Message):
    r"""A Shelf contains a collection of books with a theme.
    Attributes:
        name (str):
            The resource name of the shelf. Shelf names have the form
            ``shelves/{shelf_id}``. The name is ignored when creating a
            shelf.
        theme (str):
            The theme of the shelf
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    theme = proto.Field(
        proto.STRING,
        number=2,
    )


class CreateShelfRequest(proto.Message):
    r"""Request message for LibraryService.CreateShelf.
    Attributes:
        shelf (google.example.library_v1.types.Shelf):
            The shelf to create.
    """

    shelf = proto.Field(
        proto.MESSAGE,
        number=1,
        message='Shelf',
    )


class GetShelfRequest(proto.Message):
    r"""Request message for LibraryService.GetShelf.
    Attributes:
        name (str):
            The name of the shelf to retrieve.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class ListShelvesRequest(proto.Message):
    r"""Request message for LibraryService.ListShelves.
    Attributes:
        page_size (int):
            Requested page size. Server may return fewer
            shelves than requested. If unspecified, server
            will pick an appropriate default.
        page_token (str):
            A token identifying a page of results the server should
            return. Typically, this is the value of
            [ListShelvesResponse.next_page_token][google.example.library.v1.ListShelvesResponse.next_page_token]
            returned from the previous call to ``ListShelves`` method.
    """

    page_size = proto.Field(
        proto.INT32,
        number=1,
    )
    page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class ListShelvesResponse(proto.Message):
    r"""Response message for LibraryService.ListShelves.
    Attributes:
        shelves (Sequence[google.example.library_v1.types.Shelf]):
            The list of shelves.
        next_page_token (str):
            A token to retrieve next page of results. Pass this value in
            the
            [ListShelvesRequest.page_token][google.example.library.v1.ListShelvesRequest.page_token]
            field in the subsequent call to ``ListShelves`` method to
            retrieve the next page of results.
    """

    @property
    def raw_page(self):
        return self

    shelves = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Shelf',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class DeleteShelfRequest(proto.Message):
    r"""Request message for LibraryService.DeleteShelf.
    Attributes:
        name (str):
            The name of the shelf to delete.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class MergeShelvesRequest(proto.Message):
    r"""Describes the shelf being removed (other_shelf_name) and updated
    (name) in this merge.

    Attributes:
        name (str):
            The name of the shelf we're adding books to.
        other_shelf (str):
            The name of the shelf we're removing books
            from and deleting.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    other_shelf = proto.Field(
        proto.STRING,
        number=2,
    )


class CreateBookRequest(proto.Message):
    r"""Request message for LibraryService.CreateBook.
    Attributes:
        parent (str):
            The name of the shelf in which the book is
            created.
        book (google.example.library_v1.types.Book):
            The book to create.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    book = proto.Field(
        proto.MESSAGE,
        number=2,
        message='Book',
    )


class GetBookRequest(proto.Message):
    r"""Request message for LibraryService.GetBook.
    Attributes:
        name (str):
            The name of the book to retrieve.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class ListBooksRequest(proto.Message):
    r"""Request message for LibraryService.ListBooks.
    Attributes:
        parent (str):
            The name of the shelf whose books we'd like
            to list.
        page_size (int):
            Requested page size. Server may return fewer
            books than requested. If unspecified, server
            will pick an appropriate default.
        page_token (str):
            A token identifying a page of results the server should
            return. Typically, this is the value of
            [ListBooksResponse.next_page_token][google.example.library.v1.ListBooksResponse.next_page_token].
            returned from the previous call to ``ListBooks`` method.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    page_size = proto.Field(
        proto.INT32,
        number=2,
    )
    page_token = proto.Field(
        proto.STRING,
        number=3,
    )


class ListBooksResponse(proto.Message):
    r"""Response message for LibraryService.ListBooks.
    Attributes:
        books (Sequence[google.example.library_v1.types.Book]):
            The list of books.
        next_page_token (str):
            A token to retrieve next page of results. Pass this value in
            the
            [ListBooksRequest.page_token][google.example.library.v1.ListBooksRequest.page_token]
            field in the subsequent call to ``ListBooks`` method to
            retrieve the next page of results.
    """

    @property
    def raw_page(self):
        return self

    books = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Book',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class UpdateBookRequest(proto.Message):
    r"""Request message for LibraryService.UpdateBook.
    Attributes:
        book (google.example.library_v1.types.Book):
            The name of the book to update.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            Required. Mask of fields to update.
    """

    book = proto.Field(
        proto.MESSAGE,
        number=1,
        message='Book',
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=2,
        message=field_mask_pb2.FieldMask,
    )


class DeleteBookRequest(proto.Message):
    r"""Request message for LibraryService.DeleteBook.
    Attributes:
        name (str):
            The name of the book to delete.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class MoveBookRequest(proto.Message):
    r"""Describes what book to move (name) and what shelf we're moving it to
    (other_shelf_name).

    Attributes:
        name (str):
            The name of the book to move.
        other_shelf_name (str):
            The name of the destination shelf.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    other_shelf_name = proto.Field(
        proto.STRING,
        number=2,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
