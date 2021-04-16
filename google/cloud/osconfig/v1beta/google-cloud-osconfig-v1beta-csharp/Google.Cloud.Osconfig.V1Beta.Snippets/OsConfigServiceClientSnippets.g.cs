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

namespace Google.Cloud.Osconfig.V1Beta.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedOsConfigServiceClientSnippets
    {
        /// <summary>Snippet for ExecutePatchJob</summary>
        public void ExecutePatchJobRequestObject()
        {
            // Snippet: ExecutePatchJob(ExecutePatchJobRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ExecutePatchJobRequest request = new ExecutePatchJobRequest
            {
                Parent = "",
                Description = "",
                PatchConfig = new PatchConfig(),
                Duration = new Duration(),
                DryRun = false,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "",
            };
            // Make the request
            PatchJob response = osConfigServiceClient.ExecutePatchJob(request);
            // End snippet
        }

        /// <summary>Snippet for ExecutePatchJobAsync</summary>
        public async Task ExecutePatchJobRequestObjectAsync()
        {
            // Snippet: ExecutePatchJobAsync(ExecutePatchJobRequest, CallSettings)
            // Additional: ExecutePatchJobAsync(ExecutePatchJobRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecutePatchJobRequest request = new ExecutePatchJobRequest
            {
                Parent = "",
                Description = "",
                PatchConfig = new PatchConfig(),
                Duration = new Duration(),
                DryRun = false,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "",
            };
            // Make the request
            PatchJob response = await osConfigServiceClient.ExecutePatchJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPatchJob</summary>
        public void GetPatchJobRequestObject()
        {
            // Snippet: GetPatchJob(GetPatchJobRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            GetPatchJobRequest request = new GetPatchJobRequest { Name = "", };
            // Make the request
            PatchJob response = osConfigServiceClient.GetPatchJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetPatchJobAsync</summary>
        public async Task GetPatchJobRequestObjectAsync()
        {
            // Snippet: GetPatchJobAsync(GetPatchJobRequest, CallSettings)
            // Additional: GetPatchJobAsync(GetPatchJobRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPatchJobRequest request = new GetPatchJobRequest { Name = "", };
            // Make the request
            PatchJob response = await osConfigServiceClient.GetPatchJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelPatchJob</summary>
        public void CancelPatchJobRequestObject()
        {
            // Snippet: CancelPatchJob(CancelPatchJobRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            CancelPatchJobRequest request = new CancelPatchJobRequest { Name = "", };
            // Make the request
            PatchJob response = osConfigServiceClient.CancelPatchJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelPatchJobAsync</summary>
        public async Task CancelPatchJobRequestObjectAsync()
        {
            // Snippet: CancelPatchJobAsync(CancelPatchJobRequest, CallSettings)
            // Additional: CancelPatchJobAsync(CancelPatchJobRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelPatchJobRequest request = new CancelPatchJobRequest { Name = "", };
            // Make the request
            PatchJob response = await osConfigServiceClient.CancelPatchJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobs</summary>
        public void ListPatchJobsRequestObject()
        {
            // Snippet: ListPatchJobs(ListPatchJobsRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ListPatchJobsRequest request = new ListPatchJobsRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListPatchJobsResponse, PatchJob> response = osConfigServiceClient.ListPatchJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PatchJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPatchJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobs</summary>
        public async Task ListPatchJobsRequestObjectAsync()
        {
            // Snippet: ListPatchJobsAsync(ListPatchJobsRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPatchJobsRequest request = new ListPatchJobsRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPatchJobsResponse, PatchJob> response = osConfigServiceClient.ListPatchJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PatchJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPatchJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobInstanceDetails</summary>
        public void ListPatchJobInstanceDetailsRequestObject()
        {
            // Snippet: ListPatchJobInstanceDetails(ListPatchJobInstanceDetailsRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ListPatchJobInstanceDetailsRequest request = new ListPatchJobInstanceDetailsRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> response = osConfigServiceClient.ListPatchJobInstanceDetails(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PatchJobInstanceDetails item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPatchJobInstanceDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJobInstanceDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJobInstanceDetails> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJobInstanceDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobInstanceDetails</summary>
        public async Task ListPatchJobInstanceDetailsRequestObjectAsync()
        {
            // Snippet: ListPatchJobInstanceDetailsAsync(ListPatchJobInstanceDetailsRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPatchJobInstanceDetailsRequest request = new ListPatchJobInstanceDetailsRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> response = osConfigServiceClient.ListPatchJobInstanceDetailsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PatchJobInstanceDetails item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPatchJobInstanceDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJobInstanceDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJobInstanceDetails> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJobInstanceDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobInstanceDetails</summary>
        public void ListPatchJobInstanceDetails()
        {
            // Snippet: ListPatchJobInstanceDetails(string, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> response = osConfigServiceClient.ListPatchJobInstanceDetails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PatchJobInstanceDetails item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPatchJobInstanceDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJobInstanceDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJobInstanceDetails> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJobInstanceDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobInstanceDetails</summary>
        public async Task ListPatchJobInstanceDetailsAsync()
        {
            // Snippet: ListPatchJobInstanceDetailsAsync(string, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> response = osConfigServiceClient.ListPatchJobInstanceDetailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PatchJobInstanceDetails item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPatchJobInstanceDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJobInstanceDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJobInstanceDetails> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJobInstanceDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreatePatchDeployment</summary>
        public void CreatePatchDeploymentRequestObject()
        {
            // Snippet: CreatePatchDeployment(CreatePatchDeploymentRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            CreatePatchDeploymentRequest request = new CreatePatchDeploymentRequest
            {
                Parent = "",
                PatchDeploymentId = "",
                PatchDeployment = new PatchDeployment(),
            };
            // Make the request
            PatchDeployment response = osConfigServiceClient.CreatePatchDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePatchDeploymentAsync</summary>
        public async Task CreatePatchDeploymentRequestObjectAsync()
        {
            // Snippet: CreatePatchDeploymentAsync(CreatePatchDeploymentRequest, CallSettings)
            // Additional: CreatePatchDeploymentAsync(CreatePatchDeploymentRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreatePatchDeploymentRequest request = new CreatePatchDeploymentRequest
            {
                Parent = "",
                PatchDeploymentId = "",
                PatchDeployment = new PatchDeployment(),
            };
            // Make the request
            PatchDeployment response = await osConfigServiceClient.CreatePatchDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPatchDeployment</summary>
        public void GetPatchDeploymentRequestObject()
        {
            // Snippet: GetPatchDeployment(GetPatchDeploymentRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            GetPatchDeploymentRequest request = new GetPatchDeploymentRequest { Name = "", };
            // Make the request
            PatchDeployment response = osConfigServiceClient.GetPatchDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetPatchDeploymentAsync</summary>
        public async Task GetPatchDeploymentRequestObjectAsync()
        {
            // Snippet: GetPatchDeploymentAsync(GetPatchDeploymentRequest, CallSettings)
            // Additional: GetPatchDeploymentAsync(GetPatchDeploymentRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPatchDeploymentRequest request = new GetPatchDeploymentRequest { Name = "", };
            // Make the request
            PatchDeployment response = await osConfigServiceClient.GetPatchDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListPatchDeployments</summary>
        public void ListPatchDeploymentsRequestObject()
        {
            // Snippet: ListPatchDeployments(ListPatchDeploymentsRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ListPatchDeploymentsRequest request = new ListPatchDeploymentsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListPatchDeploymentsResponse, PatchDeployment> response = osConfigServiceClient.ListPatchDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PatchDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPatchDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchDeployments</summary>
        public async Task ListPatchDeploymentsRequestObjectAsync()
        {
            // Snippet: ListPatchDeploymentsAsync(ListPatchDeploymentsRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPatchDeploymentsRequest request = new ListPatchDeploymentsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListPatchDeploymentsResponse, PatchDeployment> response = osConfigServiceClient.ListPatchDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PatchDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPatchDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeletePatchDeployment</summary>
        public void DeletePatchDeploymentRequestObject()
        {
            // Snippet: DeletePatchDeployment(DeletePatchDeploymentRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            DeletePatchDeploymentRequest request = new DeletePatchDeploymentRequest { Name = "", };
            // Make the request
            osConfigServiceClient.DeletePatchDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePatchDeploymentAsync</summary>
        public async Task DeletePatchDeploymentRequestObjectAsync()
        {
            // Snippet: DeletePatchDeploymentAsync(DeletePatchDeploymentRequest, CallSettings)
            // Additional: DeletePatchDeploymentAsync(DeletePatchDeploymentRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeletePatchDeploymentRequest request = new DeletePatchDeploymentRequest { Name = "", };
            // Make the request
            await osConfigServiceClient.DeletePatchDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGuestPolicy</summary>
        public void CreateGuestPolicyRequestObject()
        {
            // Snippet: CreateGuestPolicy(CreateGuestPolicyRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            CreateGuestPolicyRequest request = new CreateGuestPolicyRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                GuestPolicyId = "",
                GuestPolicy = new GuestPolicy(),
            };
            // Make the request
            GuestPolicy response = osConfigServiceClient.CreateGuestPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGuestPolicyAsync</summary>
        public async Task CreateGuestPolicyRequestObjectAsync()
        {
            // Snippet: CreateGuestPolicyAsync(CreateGuestPolicyRequest, CallSettings)
            // Additional: CreateGuestPolicyAsync(CreateGuestPolicyRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateGuestPolicyRequest request = new CreateGuestPolicyRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                GuestPolicyId = "",
                GuestPolicy = new GuestPolicy(),
            };
            // Make the request
            GuestPolicy response = await osConfigServiceClient.CreateGuestPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGuestPolicy</summary>
        public void CreateGuestPolicy()
        {
            // Snippet: CreateGuestPolicy(string, GuestPolicy, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            GuestPolicy guestPolicy = new GuestPolicy();
            // Make the request
            GuestPolicy response = osConfigServiceClient.CreateGuestPolicy(parent, guestPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateGuestPolicyAsync</summary>
        public async Task CreateGuestPolicyAsync()
        {
            // Snippet: CreateGuestPolicyAsync(string, GuestPolicy, CallSettings)
            // Additional: CreateGuestPolicyAsync(string, GuestPolicy, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            GuestPolicy guestPolicy = new GuestPolicy();
            // Make the request
            GuestPolicy response = await osConfigServiceClient.CreateGuestPolicyAsync(parent, guestPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateGuestPolicy</summary>
        public void CreateGuestPolicyResourceNames()
        {
            // Snippet: CreateGuestPolicy(ProjectName, GuestPolicy, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            GuestPolicy guestPolicy = new GuestPolicy();
            // Make the request
            GuestPolicy response = osConfigServiceClient.CreateGuestPolicy(parent, guestPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateGuestPolicyAsync</summary>
        public async Task CreateGuestPolicyResourceNamesAsync()
        {
            // Snippet: CreateGuestPolicyAsync(ProjectName, GuestPolicy, CallSettings)
            // Additional: CreateGuestPolicyAsync(ProjectName, GuestPolicy, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            GuestPolicy guestPolicy = new GuestPolicy();
            // Make the request
            GuestPolicy response = await osConfigServiceClient.CreateGuestPolicyAsync(parent, guestPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetGuestPolicy</summary>
        public void GetGuestPolicyRequestObject()
        {
            // Snippet: GetGuestPolicy(GetGuestPolicyRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            GetGuestPolicyRequest request = new GetGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            // Make the request
            GuestPolicy response = osConfigServiceClient.GetGuestPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetGuestPolicyAsync</summary>
        public async Task GetGuestPolicyRequestObjectAsync()
        {
            // Snippet: GetGuestPolicyAsync(GetGuestPolicyRequest, CallSettings)
            // Additional: GetGuestPolicyAsync(GetGuestPolicyRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGuestPolicyRequest request = new GetGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            // Make the request
            GuestPolicy response = await osConfigServiceClient.GetGuestPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGuestPolicy</summary>
        public void GetGuestPolicy()
        {
            // Snippet: GetGuestPolicy(string, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/guestPolicies/[GUEST_POLICY]";
            // Make the request
            GuestPolicy response = osConfigServiceClient.GetGuestPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetGuestPolicyAsync</summary>
        public async Task GetGuestPolicyAsync()
        {
            // Snippet: GetGuestPolicyAsync(string, CallSettings)
            // Additional: GetGuestPolicyAsync(string, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/guestPolicies/[GUEST_POLICY]";
            // Make the request
            GuestPolicy response = await osConfigServiceClient.GetGuestPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGuestPolicy</summary>
        public void GetGuestPolicyResourceNames()
        {
            // Snippet: GetGuestPolicy(GuestPolicyName, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            GuestPolicyName name = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]");
            // Make the request
            GuestPolicy response = osConfigServiceClient.GetGuestPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetGuestPolicyAsync</summary>
        public async Task GetGuestPolicyResourceNamesAsync()
        {
            // Snippet: GetGuestPolicyAsync(GuestPolicyName, CallSettings)
            // Additional: GetGuestPolicyAsync(GuestPolicyName, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GuestPolicyName name = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]");
            // Make the request
            GuestPolicy response = await osConfigServiceClient.GetGuestPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGuestPolicies</summary>
        public void ListGuestPoliciesRequestObject()
        {
            // Snippet: ListGuestPolicies(ListGuestPoliciesRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ListGuestPoliciesRequest request = new ListGuestPoliciesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListGuestPoliciesResponse, GuestPolicy> response = osConfigServiceClient.ListGuestPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GuestPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGuestPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GuestPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GuestPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GuestPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGuestPolicies</summary>
        public async Task ListGuestPoliciesRequestObjectAsync()
        {
            // Snippet: ListGuestPoliciesAsync(ListGuestPoliciesRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGuestPoliciesRequest request = new ListGuestPoliciesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListGuestPoliciesResponse, GuestPolicy> response = osConfigServiceClient.ListGuestPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GuestPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGuestPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GuestPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GuestPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GuestPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGuestPolicies</summary>
        public void ListGuestPolicies()
        {
            // Snippet: ListGuestPolicies(string, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListGuestPoliciesResponse, GuestPolicy> response = osConfigServiceClient.ListGuestPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GuestPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGuestPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GuestPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GuestPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GuestPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGuestPolicies</summary>
        public async Task ListGuestPoliciesAsync()
        {
            // Snippet: ListGuestPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListGuestPoliciesResponse, GuestPolicy> response = osConfigServiceClient.ListGuestPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GuestPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGuestPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GuestPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GuestPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GuestPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGuestPolicies</summary>
        public void ListGuestPoliciesResourceNames()
        {
            // Snippet: ListGuestPolicies(ProjectName, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListGuestPoliciesResponse, GuestPolicy> response = osConfigServiceClient.ListGuestPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GuestPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGuestPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GuestPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GuestPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GuestPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGuestPolicies</summary>
        public async Task ListGuestPoliciesResourceNamesAsync()
        {
            // Snippet: ListGuestPoliciesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListGuestPoliciesResponse, GuestPolicy> response = osConfigServiceClient.ListGuestPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GuestPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGuestPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GuestPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GuestPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GuestPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateGuestPolicy</summary>
        public void UpdateGuestPolicyRequestObject()
        {
            // Snippet: UpdateGuestPolicy(UpdateGuestPolicyRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            UpdateGuestPolicyRequest request = new UpdateGuestPolicyRequest
            {
                GuestPolicy = new GuestPolicy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GuestPolicy response = osConfigServiceClient.UpdateGuestPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGuestPolicyAsync</summary>
        public async Task UpdateGuestPolicyRequestObjectAsync()
        {
            // Snippet: UpdateGuestPolicyAsync(UpdateGuestPolicyRequest, CallSettings)
            // Additional: UpdateGuestPolicyAsync(UpdateGuestPolicyRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGuestPolicyRequest request = new UpdateGuestPolicyRequest
            {
                GuestPolicy = new GuestPolicy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GuestPolicy response = await osConfigServiceClient.UpdateGuestPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGuestPolicy</summary>
        public void UpdateGuestPolicy()
        {
            // Snippet: UpdateGuestPolicy(GuestPolicy, FieldMask, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            GuestPolicy guestPolicy = new GuestPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            GuestPolicy response = osConfigServiceClient.UpdateGuestPolicy(guestPolicy, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateGuestPolicyAsync</summary>
        public async Task UpdateGuestPolicyAsync()
        {
            // Snippet: UpdateGuestPolicyAsync(GuestPolicy, FieldMask, CallSettings)
            // Additional: UpdateGuestPolicyAsync(GuestPolicy, FieldMask, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GuestPolicy guestPolicy = new GuestPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            GuestPolicy response = await osConfigServiceClient.UpdateGuestPolicyAsync(guestPolicy, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteGuestPolicy</summary>
        public void DeleteGuestPolicyRequestObject()
        {
            // Snippet: DeleteGuestPolicy(DeleteGuestPolicyRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            DeleteGuestPolicyRequest request = new DeleteGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            // Make the request
            osConfigServiceClient.DeleteGuestPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGuestPolicyAsync</summary>
        public async Task DeleteGuestPolicyRequestObjectAsync()
        {
            // Snippet: DeleteGuestPolicyAsync(DeleteGuestPolicyRequest, CallSettings)
            // Additional: DeleteGuestPolicyAsync(DeleteGuestPolicyRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGuestPolicyRequest request = new DeleteGuestPolicyRequest
            {
                GuestPolicyName = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]"),
            };
            // Make the request
            await osConfigServiceClient.DeleteGuestPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGuestPolicy</summary>
        public void DeleteGuestPolicy()
        {
            // Snippet: DeleteGuestPolicy(string, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/guestPolicies/[GUEST_POLICY]";
            // Make the request
            osConfigServiceClient.DeleteGuestPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGuestPolicyAsync</summary>
        public async Task DeleteGuestPolicyAsync()
        {
            // Snippet: DeleteGuestPolicyAsync(string, CallSettings)
            // Additional: DeleteGuestPolicyAsync(string, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/guestPolicies/[GUEST_POLICY]";
            // Make the request
            await osConfigServiceClient.DeleteGuestPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGuestPolicy</summary>
        public void DeleteGuestPolicyResourceNames()
        {
            // Snippet: DeleteGuestPolicy(GuestPolicyName, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            GuestPolicyName name = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]");
            // Make the request
            osConfigServiceClient.DeleteGuestPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGuestPolicyAsync</summary>
        public async Task DeleteGuestPolicyResourceNamesAsync()
        {
            // Snippet: DeleteGuestPolicyAsync(GuestPolicyName, CallSettings)
            // Additional: DeleteGuestPolicyAsync(GuestPolicyName, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GuestPolicyName name = GuestPolicyName.FromProjectGuestPolicy("[PROJECT]", "[GUEST_POLICY]");
            // Make the request
            await osConfigServiceClient.DeleteGuestPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LookupEffectiveGuestPolicy</summary>
        public void LookupEffectiveGuestPolicyRequestObject()
        {
            // Snippet: LookupEffectiveGuestPolicy(LookupEffectiveGuestPolicyRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            LookupEffectiveGuestPolicyRequest request = new LookupEffectiveGuestPolicyRequest
            {
                Instance = "",
                OsShortName = "",
                OsVersion = "",
                OsArchitecture = "",
            };
            // Make the request
            EffectiveGuestPolicy response = osConfigServiceClient.LookupEffectiveGuestPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for LookupEffectiveGuestPolicyAsync</summary>
        public async Task LookupEffectiveGuestPolicyRequestObjectAsync()
        {
            // Snippet: LookupEffectiveGuestPolicyAsync(LookupEffectiveGuestPolicyRequest, CallSettings)
            // Additional: LookupEffectiveGuestPolicyAsync(LookupEffectiveGuestPolicyRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            LookupEffectiveGuestPolicyRequest request = new LookupEffectiveGuestPolicyRequest
            {
                Instance = "",
                OsShortName = "",
                OsVersion = "",
                OsArchitecture = "",
            };
            // Make the request
            EffectiveGuestPolicy response = await osConfigServiceClient.LookupEffectiveGuestPolicyAsync(request);
            // End snippet
        }
    }
}
