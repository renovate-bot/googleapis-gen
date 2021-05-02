// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Example.Library.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedLibraryServiceClientSnippets
    {
        /// <summary>Snippet for CreateShelf</summary>
        public void CreateShelfRequestObject()
        {
            // Snippet: CreateShelf(CreateShelfRequest, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            CreateShelfRequest request = new CreateShelfRequest { Shelf = new Shelf(), };
            // Make the request
            Shelf response = libraryServiceClient.CreateShelf(request);
            // End snippet
        }

        /// <summary>Snippet for CreateShelfAsync</summary>
        public async Task CreateShelfRequestObjectAsync()
        {
            // Snippet: CreateShelfAsync(CreateShelfRequest, CallSettings)
            // Additional: CreateShelfAsync(CreateShelfRequest, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateShelfRequest request = new CreateShelfRequest { Shelf = new Shelf(), };
            // Make the request
            Shelf response = await libraryServiceClient.CreateShelfAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateShelf</summary>
        public void CreateShelf()
        {
            // Snippet: CreateShelf(Shelf, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            Shelf shelf = new Shelf();
            // Make the request
            Shelf response = libraryServiceClient.CreateShelf(shelf);
            // End snippet
        }

        /// <summary>Snippet for CreateShelfAsync</summary>
        public async Task CreateShelfAsync()
        {
            // Snippet: CreateShelfAsync(Shelf, CallSettings)
            // Additional: CreateShelfAsync(Shelf, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            Shelf shelf = new Shelf();
            // Make the request
            Shelf response = await libraryServiceClient.CreateShelfAsync(shelf);
            // End snippet
        }

        /// <summary>Snippet for GetShelf</summary>
        public void GetShelfRequestObject()
        {
            // Snippet: GetShelf(GetShelfRequest, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            GetShelfRequest request = new GetShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            // Make the request
            Shelf response = libraryServiceClient.GetShelf(request);
            // End snippet
        }

        /// <summary>Snippet for GetShelfAsync</summary>
        public async Task GetShelfRequestObjectAsync()
        {
            // Snippet: GetShelfAsync(GetShelfRequest, CallSettings)
            // Additional: GetShelfAsync(GetShelfRequest, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetShelfRequest request = new GetShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            // Make the request
            Shelf response = await libraryServiceClient.GetShelfAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetShelf</summary>
        public void GetShelf()
        {
            // Snippet: GetShelf(string, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            string name = "shelves/[SHELF_ID]";
            // Make the request
            Shelf response = libraryServiceClient.GetShelf(name);
            // End snippet
        }

        /// <summary>Snippet for GetShelfAsync</summary>
        public async Task GetShelfAsync()
        {
            // Snippet: GetShelfAsync(string, CallSettings)
            // Additional: GetShelfAsync(string, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "shelves/[SHELF_ID]";
            // Make the request
            Shelf response = await libraryServiceClient.GetShelfAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetShelf</summary>
        public void GetShelfResourceNames()
        {
            // Snippet: GetShelf(ShelfName, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            ShelfName name = ShelfName.FromShelf("[SHELF_ID]");
            // Make the request
            Shelf response = libraryServiceClient.GetShelf(name);
            // End snippet
        }

        /// <summary>Snippet for GetShelfAsync</summary>
        public async Task GetShelfResourceNamesAsync()
        {
            // Snippet: GetShelfAsync(ShelfName, CallSettings)
            // Additional: GetShelfAsync(ShelfName, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ShelfName name = ShelfName.FromShelf("[SHELF_ID]");
            // Make the request
            Shelf response = await libraryServiceClient.GetShelfAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListShelves</summary>
        public void ListShelvesRequestObject()
        {
            // Snippet: ListShelves(ListShelvesRequest, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            ListShelvesRequest request = new ListShelvesRequest { };
            // Make the request
            PagedEnumerable<ListShelvesResponse, Shelf> response = libraryServiceClient.ListShelves(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Shelf item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListShelvesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Shelf item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Shelf> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Shelf item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListShelvesAsync</summary>
        public async Task ListShelvesRequestObjectAsync()
        {
            // Snippet: ListShelvesAsync(ListShelvesRequest, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListShelvesRequest request = new ListShelvesRequest { };
            // Make the request
            PagedAsyncEnumerable<ListShelvesResponse, Shelf> response = libraryServiceClient.ListShelvesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Shelf item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListShelvesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Shelf item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Shelf> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Shelf item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteShelf</summary>
        public void DeleteShelfRequestObject()
        {
            // Snippet: DeleteShelf(DeleteShelfRequest, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            DeleteShelfRequest request = new DeleteShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            // Make the request
            libraryServiceClient.DeleteShelf(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteShelfAsync</summary>
        public async Task DeleteShelfRequestObjectAsync()
        {
            // Snippet: DeleteShelfAsync(DeleteShelfRequest, CallSettings)
            // Additional: DeleteShelfAsync(DeleteShelfRequest, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteShelfRequest request = new DeleteShelfRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            // Make the request
            await libraryServiceClient.DeleteShelfAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteShelf</summary>
        public void DeleteShelf()
        {
            // Snippet: DeleteShelf(string, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            string name = "shelves/[SHELF_ID]";
            // Make the request
            libraryServiceClient.DeleteShelf(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteShelfAsync</summary>
        public async Task DeleteShelfAsync()
        {
            // Snippet: DeleteShelfAsync(string, CallSettings)
            // Additional: DeleteShelfAsync(string, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "shelves/[SHELF_ID]";
            // Make the request
            await libraryServiceClient.DeleteShelfAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteShelf</summary>
        public void DeleteShelfResourceNames()
        {
            // Snippet: DeleteShelf(ShelfName, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            ShelfName name = ShelfName.FromShelf("[SHELF_ID]");
            // Make the request
            libraryServiceClient.DeleteShelf(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteShelfAsync</summary>
        public async Task DeleteShelfResourceNamesAsync()
        {
            // Snippet: DeleteShelfAsync(ShelfName, CallSettings)
            // Additional: DeleteShelfAsync(ShelfName, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ShelfName name = ShelfName.FromShelf("[SHELF_ID]");
            // Make the request
            await libraryServiceClient.DeleteShelfAsync(name);
            // End snippet
        }

        /// <summary>Snippet for MergeShelves</summary>
        public void MergeShelvesRequestObject()
        {
            // Snippet: MergeShelves(MergeShelvesRequest, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            MergeShelvesRequest request = new MergeShelvesRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                OtherShelfAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            // Make the request
            Shelf response = libraryServiceClient.MergeShelves(request);
            // End snippet
        }

        /// <summary>Snippet for MergeShelvesAsync</summary>
        public async Task MergeShelvesRequestObjectAsync()
        {
            // Snippet: MergeShelvesAsync(MergeShelvesRequest, CallSettings)
            // Additional: MergeShelvesAsync(MergeShelvesRequest, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            MergeShelvesRequest request = new MergeShelvesRequest
            {
                ShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                OtherShelfAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            // Make the request
            Shelf response = await libraryServiceClient.MergeShelvesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MergeShelves</summary>
        public void MergeShelves()
        {
            // Snippet: MergeShelves(string, string, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            string name = "shelves/[SHELF_ID]";
            string otherShelf = "shelves/[SHELF_ID]";
            // Make the request
            Shelf response = libraryServiceClient.MergeShelves(name, otherShelf);
            // End snippet
        }

        /// <summary>Snippet for MergeShelvesAsync</summary>
        public async Task MergeShelvesAsync()
        {
            // Snippet: MergeShelvesAsync(string, string, CallSettings)
            // Additional: MergeShelvesAsync(string, string, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "shelves/[SHELF_ID]";
            string otherShelf = "shelves/[SHELF_ID]";
            // Make the request
            Shelf response = await libraryServiceClient.MergeShelvesAsync(name, otherShelf);
            // End snippet
        }

        /// <summary>Snippet for MergeShelves</summary>
        public void MergeShelvesResourceNames()
        {
            // Snippet: MergeShelves(ShelfName, ShelfName, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            ShelfName name = ShelfName.FromShelf("[SHELF_ID]");
            ShelfName otherShelf = ShelfName.FromShelf("[SHELF_ID]");
            // Make the request
            Shelf response = libraryServiceClient.MergeShelves(name, otherShelf);
            // End snippet
        }

        /// <summary>Snippet for MergeShelvesAsync</summary>
        public async Task MergeShelvesResourceNamesAsync()
        {
            // Snippet: MergeShelvesAsync(ShelfName, ShelfName, CallSettings)
            // Additional: MergeShelvesAsync(ShelfName, ShelfName, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ShelfName name = ShelfName.FromShelf("[SHELF_ID]");
            ShelfName otherShelf = ShelfName.FromShelf("[SHELF_ID]");
            // Make the request
            Shelf response = await libraryServiceClient.MergeShelvesAsync(name, otherShelf);
            // End snippet
        }

        /// <summary>Snippet for CreateBook</summary>
        public void CreateBookRequestObject()
        {
            // Snippet: CreateBook(CreateBookRequest, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            CreateBookRequest request = new CreateBookRequest
            {
                ParentAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Book = new Book(),
            };
            // Make the request
            Book response = libraryServiceClient.CreateBook(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBookAsync</summary>
        public async Task CreateBookRequestObjectAsync()
        {
            // Snippet: CreateBookAsync(CreateBookRequest, CallSettings)
            // Additional: CreateBookAsync(CreateBookRequest, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateBookRequest request = new CreateBookRequest
            {
                ParentAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
                Book = new Book(),
            };
            // Make the request
            Book response = await libraryServiceClient.CreateBookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBook</summary>
        public void CreateBook()
        {
            // Snippet: CreateBook(string, Book, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "shelves/[SHELF_ID]";
            Book book = new Book();
            // Make the request
            Book response = libraryServiceClient.CreateBook(parent, book);
            // End snippet
        }

        /// <summary>Snippet for CreateBookAsync</summary>
        public async Task CreateBookAsync()
        {
            // Snippet: CreateBookAsync(string, Book, CallSettings)
            // Additional: CreateBookAsync(string, Book, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "shelves/[SHELF_ID]";
            Book book = new Book();
            // Make the request
            Book response = await libraryServiceClient.CreateBookAsync(parent, book);
            // End snippet
        }

        /// <summary>Snippet for CreateBook</summary>
        public void CreateBookResourceNames()
        {
            // Snippet: CreateBook(ShelfName, Book, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            ShelfName parent = ShelfName.FromShelf("[SHELF_ID]");
            Book book = new Book();
            // Make the request
            Book response = libraryServiceClient.CreateBook(parent, book);
            // End snippet
        }

        /// <summary>Snippet for CreateBookAsync</summary>
        public async Task CreateBookResourceNamesAsync()
        {
            // Snippet: CreateBookAsync(ShelfName, Book, CallSettings)
            // Additional: CreateBookAsync(ShelfName, Book, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ShelfName parent = ShelfName.FromShelf("[SHELF_ID]");
            Book book = new Book();
            // Make the request
            Book response = await libraryServiceClient.CreateBookAsync(parent, book);
            // End snippet
        }

        /// <summary>Snippet for GetBook</summary>
        public void GetBookRequestObject()
        {
            // Snippet: GetBook(GetBookRequest, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            GetBookRequest request = new GetBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            // Make the request
            Book response = libraryServiceClient.GetBook(request);
            // End snippet
        }

        /// <summary>Snippet for GetBookAsync</summary>
        public async Task GetBookRequestObjectAsync()
        {
            // Snippet: GetBookAsync(GetBookRequest, CallSettings)
            // Additional: GetBookAsync(GetBookRequest, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBookRequest request = new GetBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            // Make the request
            Book response = await libraryServiceClient.GetBookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBook</summary>
        public void GetBook()
        {
            // Snippet: GetBook(string, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            string name = "shelves/[SHELF]/books/[BOOK]";
            // Make the request
            Book response = libraryServiceClient.GetBook(name);
            // End snippet
        }

        /// <summary>Snippet for GetBookAsync</summary>
        public async Task GetBookAsync()
        {
            // Snippet: GetBookAsync(string, CallSettings)
            // Additional: GetBookAsync(string, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "shelves/[SHELF]/books/[BOOK]";
            // Make the request
            Book response = await libraryServiceClient.GetBookAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBook</summary>
        public void GetBookResourceNames()
        {
            // Snippet: GetBook(BookName, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            BookName name = BookName.FromShelfBook("[SHELF]", "[BOOK]");
            // Make the request
            Book response = libraryServiceClient.GetBook(name);
            // End snippet
        }

        /// <summary>Snippet for GetBookAsync</summary>
        public async Task GetBookResourceNamesAsync()
        {
            // Snippet: GetBookAsync(BookName, CallSettings)
            // Additional: GetBookAsync(BookName, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            BookName name = BookName.FromShelfBook("[SHELF]", "[BOOK]");
            // Make the request
            Book response = await libraryServiceClient.GetBookAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBooks</summary>
        public void ListBooksRequestObject()
        {
            // Snippet: ListBooks(ListBooksRequest, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            ListBooksRequest request = new ListBooksRequest
            {
                ParentAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            // Make the request
            PagedEnumerable<ListBooksResponse, Book> response = libraryServiceClient.ListBooks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Book item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Book item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Book> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Book item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBooksAsync</summary>
        public async Task ListBooksRequestObjectAsync()
        {
            // Snippet: ListBooksAsync(ListBooksRequest, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListBooksRequest request = new ListBooksRequest
            {
                ParentAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListBooksResponse, Book> response = libraryServiceClient.ListBooksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Book item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBooksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Book item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Book> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Book item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBooks</summary>
        public void ListBooks()
        {
            // Snippet: ListBooks(string, string, int?, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "shelves/[SHELF_ID]";
            // Make the request
            PagedEnumerable<ListBooksResponse, Book> response = libraryServiceClient.ListBooks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Book item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Book item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Book> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Book item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBooksAsync</summary>
        public async Task ListBooksAsync()
        {
            // Snippet: ListBooksAsync(string, string, int?, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "shelves/[SHELF_ID]";
            // Make the request
            PagedAsyncEnumerable<ListBooksResponse, Book> response = libraryServiceClient.ListBooksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Book item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBooksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Book item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Book> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Book item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBooks</summary>
        public void ListBooksResourceNames()
        {
            // Snippet: ListBooks(ShelfName, string, int?, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            ShelfName parent = ShelfName.FromShelf("[SHELF_ID]");
            // Make the request
            PagedEnumerable<ListBooksResponse, Book> response = libraryServiceClient.ListBooks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Book item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Book item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Book> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Book item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBooksAsync</summary>
        public async Task ListBooksResourceNamesAsync()
        {
            // Snippet: ListBooksAsync(ShelfName, string, int?, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ShelfName parent = ShelfName.FromShelf("[SHELF_ID]");
            // Make the request
            PagedAsyncEnumerable<ListBooksResponse, Book> response = libraryServiceClient.ListBooksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Book item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBooksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Book item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Book> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Book item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteBook</summary>
        public void DeleteBookRequestObject()
        {
            // Snippet: DeleteBook(DeleteBookRequest, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            DeleteBookRequest request = new DeleteBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            // Make the request
            libraryServiceClient.DeleteBook(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBookAsync</summary>
        public async Task DeleteBookRequestObjectAsync()
        {
            // Snippet: DeleteBookAsync(DeleteBookRequest, CallSettings)
            // Additional: DeleteBookAsync(DeleteBookRequest, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBookRequest request = new DeleteBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
            };
            // Make the request
            await libraryServiceClient.DeleteBookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBook</summary>
        public void DeleteBook()
        {
            // Snippet: DeleteBook(string, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            string name = "shelves/[SHELF]/books/[BOOK]";
            // Make the request
            libraryServiceClient.DeleteBook(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBookAsync</summary>
        public async Task DeleteBookAsync()
        {
            // Snippet: DeleteBookAsync(string, CallSettings)
            // Additional: DeleteBookAsync(string, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "shelves/[SHELF]/books/[BOOK]";
            // Make the request
            await libraryServiceClient.DeleteBookAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBook</summary>
        public void DeleteBookResourceNames()
        {
            // Snippet: DeleteBook(BookName, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            BookName name = BookName.FromShelfBook("[SHELF]", "[BOOK]");
            // Make the request
            libraryServiceClient.DeleteBook(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBookAsync</summary>
        public async Task DeleteBookResourceNamesAsync()
        {
            // Snippet: DeleteBookAsync(BookName, CallSettings)
            // Additional: DeleteBookAsync(BookName, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            BookName name = BookName.FromShelfBook("[SHELF]", "[BOOK]");
            // Make the request
            await libraryServiceClient.DeleteBookAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateBook</summary>
        public void UpdateBookRequestObject()
        {
            // Snippet: UpdateBook(UpdateBookRequest, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            UpdateBookRequest request = new UpdateBookRequest
            {
                Book = new Book(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Book response = libraryServiceClient.UpdateBook(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBookAsync</summary>
        public async Task UpdateBookRequestObjectAsync()
        {
            // Snippet: UpdateBookAsync(UpdateBookRequest, CallSettings)
            // Additional: UpdateBookAsync(UpdateBookRequest, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBookRequest request = new UpdateBookRequest
            {
                Book = new Book(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Book response = await libraryServiceClient.UpdateBookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBook</summary>
        public void UpdateBook()
        {
            // Snippet: UpdateBook(Book, FieldMask, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            Book book = new Book();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Book response = libraryServiceClient.UpdateBook(book, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateBookAsync</summary>
        public async Task UpdateBookAsync()
        {
            // Snippet: UpdateBookAsync(Book, FieldMask, CallSettings)
            // Additional: UpdateBookAsync(Book, FieldMask, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            Book book = new Book();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Book response = await libraryServiceClient.UpdateBookAsync(book, updateMask);
            // End snippet
        }

        /// <summary>Snippet for MoveBook</summary>
        public void MoveBookRequestObject()
        {
            // Snippet: MoveBook(MoveBookRequest, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            MoveBookRequest request = new MoveBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                OtherShelfNameAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            // Make the request
            Book response = libraryServiceClient.MoveBook(request);
            // End snippet
        }

        /// <summary>Snippet for MoveBookAsync</summary>
        public async Task MoveBookRequestObjectAsync()
        {
            // Snippet: MoveBookAsync(MoveBookRequest, CallSettings)
            // Additional: MoveBookAsync(MoveBookRequest, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            MoveBookRequest request = new MoveBookRequest
            {
                BookName = BookName.FromShelfBook("[SHELF]", "[BOOK]"),
                OtherShelfNameAsShelfName = ShelfName.FromShelf("[SHELF_ID]"),
            };
            // Make the request
            Book response = await libraryServiceClient.MoveBookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MoveBook</summary>
        public void MoveBook()
        {
            // Snippet: MoveBook(string, string, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            string name = "shelves/[SHELF]/books/[BOOK]";
            string otherShelfName = "shelves/[SHELF_ID]";
            // Make the request
            Book response = libraryServiceClient.MoveBook(name, otherShelfName);
            // End snippet
        }

        /// <summary>Snippet for MoveBookAsync</summary>
        public async Task MoveBookAsync()
        {
            // Snippet: MoveBookAsync(string, string, CallSettings)
            // Additional: MoveBookAsync(string, string, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "shelves/[SHELF]/books/[BOOK]";
            string otherShelfName = "shelves/[SHELF_ID]";
            // Make the request
            Book response = await libraryServiceClient.MoveBookAsync(name, otherShelfName);
            // End snippet
        }

        /// <summary>Snippet for MoveBook</summary>
        public void MoveBookResourceNames()
        {
            // Snippet: MoveBook(BookName, ShelfName, CallSettings)
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            BookName name = BookName.FromShelfBook("[SHELF]", "[BOOK]");
            ShelfName otherShelfName = ShelfName.FromShelf("[SHELF_ID]");
            // Make the request
            Book response = libraryServiceClient.MoveBook(name, otherShelfName);
            // End snippet
        }

        /// <summary>Snippet for MoveBookAsync</summary>
        public async Task MoveBookResourceNamesAsync()
        {
            // Snippet: MoveBookAsync(BookName, ShelfName, CallSettings)
            // Additional: MoveBookAsync(BookName, ShelfName, CancellationToken)
            // Create client
            LibraryServiceClient libraryServiceClient = await LibraryServiceClient.CreateAsync();
            // Initialize request argument(s)
            BookName name = BookName.FromShelfBook("[SHELF]", "[BOOK]");
            ShelfName otherShelfName = ShelfName.FromShelf("[SHELF_ID]");
            // Make the request
            Book response = await libraryServiceClient.MoveBookAsync(name, otherShelfName);
            // End snippet
        }
    }
}
