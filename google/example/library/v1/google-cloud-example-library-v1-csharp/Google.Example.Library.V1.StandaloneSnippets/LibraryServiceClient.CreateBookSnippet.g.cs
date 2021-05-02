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
    using Google.Example.Library.V1;

    public sealed partial class GeneratedLibraryServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateBook</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateBook()
        {
            // Create client
            LibraryServiceClient libraryServiceClient = LibraryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "shelves/[SHELF_ID]";
            Book book = new Book();
            // Make the request
            Book response = libraryServiceClient.CreateBook(parent, book);
        }
    }
}
