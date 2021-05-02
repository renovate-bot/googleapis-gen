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

namespace Google.Monitoring.Dashboard.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedDashboardsServiceClientSnippets
    {
        /// <summary>Snippet for CreateDashboard</summary>
        public void CreateDashboardRequestObject()
        {
            // Snippet: CreateDashboard(CreateDashboardRequest, CallSettings)
            // Create client
            DashboardsServiceClient dashboardsServiceClient = DashboardsServiceClient.Create();
            // Initialize request argument(s)
            CreateDashboardRequest request = new CreateDashboardRequest
            {
                Parent = "",
                Dashboard = new Dashboard(),
            };
            // Make the request
            Dashboard response = dashboardsServiceClient.CreateDashboard(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDashboardAsync</summary>
        public async Task CreateDashboardRequestObjectAsync()
        {
            // Snippet: CreateDashboardAsync(CreateDashboardRequest, CallSettings)
            // Additional: CreateDashboardAsync(CreateDashboardRequest, CancellationToken)
            // Create client
            DashboardsServiceClient dashboardsServiceClient = await DashboardsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDashboardRequest request = new CreateDashboardRequest
            {
                Parent = "",
                Dashboard = new Dashboard(),
            };
            // Make the request
            Dashboard response = await dashboardsServiceClient.CreateDashboardAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListDashboards</summary>
        public void ListDashboardsRequestObject()
        {
            // Snippet: ListDashboards(ListDashboardsRequest, CallSettings)
            // Create client
            DashboardsServiceClient dashboardsServiceClient = DashboardsServiceClient.Create();
            // Initialize request argument(s)
            ListDashboardsRequest request = new ListDashboardsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListDashboardsResponse, Dashboard> response = dashboardsServiceClient.ListDashboards(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dashboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDashboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dashboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dashboard> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dashboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDashboardsAsync</summary>
        public async Task ListDashboardsRequestObjectAsync()
        {
            // Snippet: ListDashboardsAsync(ListDashboardsRequest, CallSettings)
            // Create client
            DashboardsServiceClient dashboardsServiceClient = await DashboardsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDashboardsRequest request = new ListDashboardsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDashboardsResponse, Dashboard> response = dashboardsServiceClient.ListDashboardsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dashboard item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDashboardsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dashboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dashboard> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dashboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDashboard</summary>
        public void GetDashboardRequestObject()
        {
            // Snippet: GetDashboard(GetDashboardRequest, CallSettings)
            // Create client
            DashboardsServiceClient dashboardsServiceClient = DashboardsServiceClient.Create();
            // Initialize request argument(s)
            GetDashboardRequest request = new GetDashboardRequest
            {
                DashboardName = DashboardName.FromProjectDashboard("[PROJECT]", "[DASHBOARD]"),
            };
            // Make the request
            Dashboard response = dashboardsServiceClient.GetDashboard(request);
            // End snippet
        }

        /// <summary>Snippet for GetDashboardAsync</summary>
        public async Task GetDashboardRequestObjectAsync()
        {
            // Snippet: GetDashboardAsync(GetDashboardRequest, CallSettings)
            // Additional: GetDashboardAsync(GetDashboardRequest, CancellationToken)
            // Create client
            DashboardsServiceClient dashboardsServiceClient = await DashboardsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDashboardRequest request = new GetDashboardRequest
            {
                DashboardName = DashboardName.FromProjectDashboard("[PROJECT]", "[DASHBOARD]"),
            };
            // Make the request
            Dashboard response = await dashboardsServiceClient.GetDashboardAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDashboard</summary>
        public void DeleteDashboardRequestObject()
        {
            // Snippet: DeleteDashboard(DeleteDashboardRequest, CallSettings)
            // Create client
            DashboardsServiceClient dashboardsServiceClient = DashboardsServiceClient.Create();
            // Initialize request argument(s)
            DeleteDashboardRequest request = new DeleteDashboardRequest
            {
                DashboardName = DashboardName.FromProjectDashboard("[PROJECT]", "[DASHBOARD]"),
            };
            // Make the request
            dashboardsServiceClient.DeleteDashboard(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDashboardAsync</summary>
        public async Task DeleteDashboardRequestObjectAsync()
        {
            // Snippet: DeleteDashboardAsync(DeleteDashboardRequest, CallSettings)
            // Additional: DeleteDashboardAsync(DeleteDashboardRequest, CancellationToken)
            // Create client
            DashboardsServiceClient dashboardsServiceClient = await DashboardsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDashboardRequest request = new DeleteDashboardRequest
            {
                DashboardName = DashboardName.FromProjectDashboard("[PROJECT]", "[DASHBOARD]"),
            };
            // Make the request
            await dashboardsServiceClient.DeleteDashboardAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDashboard</summary>
        public void UpdateDashboardRequestObject()
        {
            // Snippet: UpdateDashboard(UpdateDashboardRequest, CallSettings)
            // Create client
            DashboardsServiceClient dashboardsServiceClient = DashboardsServiceClient.Create();
            // Initialize request argument(s)
            UpdateDashboardRequest request = new UpdateDashboardRequest
            {
                Dashboard = new Dashboard(),
            };
            // Make the request
            Dashboard response = dashboardsServiceClient.UpdateDashboard(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDashboardAsync</summary>
        public async Task UpdateDashboardRequestObjectAsync()
        {
            // Snippet: UpdateDashboardAsync(UpdateDashboardRequest, CallSettings)
            // Additional: UpdateDashboardAsync(UpdateDashboardRequest, CancellationToken)
            // Create client
            DashboardsServiceClient dashboardsServiceClient = await DashboardsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDashboardRequest request = new UpdateDashboardRequest
            {
                Dashboard = new Dashboard(),
            };
            // Make the request
            Dashboard response = await dashboardsServiceClient.UpdateDashboardAsync(request);
            // End snippet
        }
    }
}
