# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

module Google
  module Example
    module Library
      module V1
        # A single book in the library.
        # @!attribute [rw] name
        #   @return [String]
        #     The resource name of the book.
        #     Book names have the form `shelves/{shelf_id}/books/{book_id}`.
        #     The name is ignored when creating a book.
        # @!attribute [rw] author
        #   @return [String]
        #     The name of the book author.
        # @!attribute [rw] title
        #   @return [String]
        #     The title of the book.
        # @!attribute [rw] read
        #   @return [true, false]
        #     Value indicating whether the book has been read.
        class Book; end

        # A Shelf contains a collection of books with a theme.
        # @!attribute [rw] name
        #   @return [String]
        #     The resource name of the shelf.
        #     Shelf names have the form `shelves/{shelf_id}`.
        #     The name is ignored when creating a shelf.
        # @!attribute [rw] theme
        #   @return [String]
        #     The theme of the shelf
        class Shelf; end

        # Request message for LibraryService.CreateShelf.
        # @!attribute [rw] shelf
        #   @return [Google::Example::Library::V1::Shelf]
        #     The shelf to create.
        class CreateShelfRequest; end

        # Request message for LibraryService.GetShelf.
        # @!attribute [rw] name
        #   @return [String]
        #     The name of the shelf to retrieve.
        class GetShelfRequest; end

        # Request message for LibraryService.ListShelves.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Requested page size. Server may return fewer shelves than requested.
        #     If unspecified, server will pick an appropriate default.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A token identifying a page of results the server should return.
        #     Typically, this is the value of
        #     {Google::Example::Library::V1::ListShelvesResponse#next_page_token ListShelvesResponse#next_page_token}
        #     returned from the previous call to `ListShelves` method.
        class ListShelvesRequest; end

        # Response message for LibraryService.ListShelves.
        # @!attribute [rw] shelves
        #   @return [Array<Google::Example::Library::V1::Shelf>]
        #     The list of shelves.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token to retrieve next page of results.
        #     Pass this value in the
        #     {Google::Example::Library::V1::ListShelvesRequest#page_token ListShelvesRequest#page_token}
        #     field in the subsequent call to `ListShelves` method to retrieve the next
        #     page of results.
        class ListShelvesResponse; end

        # Request message for LibraryService.DeleteShelf.
        # @!attribute [rw] name
        #   @return [String]
        #     The name of the shelf to delete.
        class DeleteShelfRequest; end

        # Describes the shelf being removed (other_shelf_name) and updated
        # (name) in this merge.
        # @!attribute [rw] name
        #   @return [String]
        #     The name of the shelf we're adding books to.
        # @!attribute [rw] other_shelf_name
        #   @return [String]
        #     The name of the shelf we're removing books from and deleting.
        class MergeShelvesRequest; end

        # Request message for LibraryService.CreateBook.
        # @!attribute [rw] name
        #   @return [String]
        #     The name of the shelf in which the book is created.
        # @!attribute [rw] book
        #   @return [Google::Example::Library::V1::Book]
        #     The book to create.
        class CreateBookRequest; end

        # Request message for LibraryService.GetBook.
        # @!attribute [rw] name
        #   @return [String]
        #     The name of the book to retrieve.
        class GetBookRequest; end

        # Request message for LibraryService.ListBooks.
        # @!attribute [rw] name
        #   @return [String]
        #     The name of the shelf whose books we'd like to list.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Requested page size. Server may return fewer books than requested.
        #     If unspecified, server will pick an appropriate default.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A token identifying a page of results the server should return.
        #     Typically, this is the value of
        #     {Google::Example::Library::V1::ListBooksResponse#next_page_token ListBooksResponse#next_page_token}.
        #     returned from the previous call to `ListBooks` method.
        class ListBooksRequest; end

        # Response message for LibraryService.ListBooks.
        # @!attribute [rw] books
        #   @return [Array<Google::Example::Library::V1::Book>]
        #     The list of books.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token to retrieve next page of results.
        #     Pass this value in the
        #     {Google::Example::Library::V1::ListBooksRequest#page_token ListBooksRequest#page_token}
        #     field in the subsequent call to `ListBooks` method to retrieve the next
        #     page of results.
        class ListBooksResponse; end

        # Request message for LibraryService.UpdateBook.
        # @!attribute [rw] name
        #   @return [String]
        #     The name of the book to update.
        # @!attribute [rw] book
        #   @return [Google::Example::Library::V1::Book]
        #     The book to update with. The name must match or be empty.
        class UpdateBookRequest; end

        # Request message for LibraryService.DeleteBook.
        # @!attribute [rw] name
        #   @return [String]
        #     The name of the book to delete.
        class DeleteBookRequest; end

        # Describes what book to move (name) and what shelf we're moving it
        # to (other_shelf_name).
        # @!attribute [rw] name
        #   @return [String]
        #     The name of the book to move.
        # @!attribute [rw] other_shelf_name
        #   @return [String]
        #     The name of the destination shelf.
        class MoveBookRequest; end
      end
    end
  end
end