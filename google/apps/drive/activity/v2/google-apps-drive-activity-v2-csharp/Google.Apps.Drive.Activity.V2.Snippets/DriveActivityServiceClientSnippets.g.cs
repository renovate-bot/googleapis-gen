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

namespace Google.Apps.Drive.Activity.V2.Snippets
{
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedDriveActivityServiceClientSnippets
    {
        /// <summary>Snippet for QueryDriveActivity</summary>
        public void QueryDriveActivityRequestObject()
        {
            // Snippet: QueryDriveActivity(QueryDriveActivityRequest, CallSettings)
            // Create client
            DriveActivityServiceClient driveActivityServiceClient = DriveActivityServiceClient.Create();
            // Initialize request argument(s)
            QueryDriveActivityRequest request = new QueryDriveActivityRequest
            {
                ItemName = "",
                ConsolidationStrategy = new ConsolidationStrategy(),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<QueryDriveActivityResponse, DriveActivity> response = driveActivityServiceClient.QueryDriveActivity(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DriveActivity item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryDriveActivityResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DriveActivity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DriveActivity> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DriveActivity item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryDriveActivityAsync</summary>
        public async Task QueryDriveActivityRequestObjectAsync()
        {
            // Snippet: QueryDriveActivityAsync(QueryDriveActivityRequest, CallSettings)
            // Create client
            DriveActivityServiceClient driveActivityServiceClient = await DriveActivityServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryDriveActivityRequest request = new QueryDriveActivityRequest
            {
                ItemName = "",
                ConsolidationStrategy = new ConsolidationStrategy(),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<QueryDriveActivityResponse, DriveActivity> response = driveActivityServiceClient.QueryDriveActivityAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DriveActivity item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryDriveActivityResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DriveActivity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DriveActivity> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DriveActivity item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
