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

namespace Google.Ads.GoogleAds.V5.Services.Snippets
{
    using Google.Ads.GoogleAds.V5.Enums;
    using Google.Ads.GoogleAds.V5.Resources;
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using Google.Rpc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCampaignDraftServiceClientSnippets
    {
        /// <summary>Snippet for GetCampaignDraft</summary>
        public void GetCampaignDraftRequestObject()
        {
            // Snippet: GetCampaignDraft(GetCampaignDraftRequest, CallSettings)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = CampaignDraftServiceClient.Create();
            // Initialize request argument(s)
            GetCampaignDraftRequest request = new GetCampaignDraftRequest
            {
                ResourceNameAsCampaignDraftName = CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
            };
            // Make the request
            CampaignDraft response = campaignDraftServiceClient.GetCampaignDraft(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignDraftAsync</summary>
        public async Task GetCampaignDraftRequestObjectAsync()
        {
            // Snippet: GetCampaignDraftAsync(GetCampaignDraftRequest, CallSettings)
            // Additional: GetCampaignDraftAsync(GetCampaignDraftRequest, CancellationToken)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = await CampaignDraftServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCampaignDraftRequest request = new GetCampaignDraftRequest
            {
                ResourceNameAsCampaignDraftName = CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
            };
            // Make the request
            CampaignDraft response = await campaignDraftServiceClient.GetCampaignDraftAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignDraft</summary>
        public void GetCampaignDraft()
        {
            // Snippet: GetCampaignDraft(string, CallSettings)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = CampaignDraftServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaignDrafts/[CAMPAIGN_DRAFT]";
            // Make the request
            CampaignDraft response = campaignDraftServiceClient.GetCampaignDraft(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignDraftAsync</summary>
        public async Task GetCampaignDraftAsync()
        {
            // Snippet: GetCampaignDraftAsync(string, CallSettings)
            // Additional: GetCampaignDraftAsync(string, CancellationToken)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = await CampaignDraftServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaignDrafts/[CAMPAIGN_DRAFT]";
            // Make the request
            CampaignDraft response = await campaignDraftServiceClient.GetCampaignDraftAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignDraft</summary>
        public void GetCampaignDraftResourceNames()
        {
            // Snippet: GetCampaignDraft(CampaignDraftName, CallSettings)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = CampaignDraftServiceClient.Create();
            // Initialize request argument(s)
            CampaignDraftName resourceName = CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]");
            // Make the request
            CampaignDraft response = campaignDraftServiceClient.GetCampaignDraft(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignDraftAsync</summary>
        public async Task GetCampaignDraftResourceNamesAsync()
        {
            // Snippet: GetCampaignDraftAsync(CampaignDraftName, CallSettings)
            // Additional: GetCampaignDraftAsync(CampaignDraftName, CancellationToken)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = await CampaignDraftServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignDraftName resourceName = CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]");
            // Make the request
            CampaignDraft response = await campaignDraftServiceClient.GetCampaignDraftAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignDrafts</summary>
        public void MutateCampaignDraftsRequestObject()
        {
            // Snippet: MutateCampaignDrafts(MutateCampaignDraftsRequest, CallSettings)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = CampaignDraftServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignDraftsRequest request = new MutateCampaignDraftsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignDraftOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignDraftsResponse response = campaignDraftServiceClient.MutateCampaignDrafts(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignDraftsAsync</summary>
        public async Task MutateCampaignDraftsRequestObjectAsync()
        {
            // Snippet: MutateCampaignDraftsAsync(MutateCampaignDraftsRequest, CallSettings)
            // Additional: MutateCampaignDraftsAsync(MutateCampaignDraftsRequest, CancellationToken)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = await CampaignDraftServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignDraftsRequest request = new MutateCampaignDraftsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignDraftOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignDraftsResponse response = await campaignDraftServiceClient.MutateCampaignDraftsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignDrafts</summary>
        public void MutateCampaignDrafts()
        {
            // Snippet: MutateCampaignDrafts(string, IEnumerable<CampaignDraftOperation>, CallSettings)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = CampaignDraftServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignDraftOperation> operations = new CampaignDraftOperation[]
            {
                new CampaignDraftOperation(),
            };
            // Make the request
            MutateCampaignDraftsResponse response = campaignDraftServiceClient.MutateCampaignDrafts(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignDraftsAsync</summary>
        public async Task MutateCampaignDraftsAsync()
        {
            // Snippet: MutateCampaignDraftsAsync(string, IEnumerable<CampaignDraftOperation>, CallSettings)
            // Additional: MutateCampaignDraftsAsync(string, IEnumerable<CampaignDraftOperation>, CancellationToken)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = await CampaignDraftServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignDraftOperation> operations = new CampaignDraftOperation[]
            {
                new CampaignDraftOperation(),
            };
            // Make the request
            MutateCampaignDraftsResponse response = await campaignDraftServiceClient.MutateCampaignDraftsAsync(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for PromoteCampaignDraft</summary>
        public void PromoteCampaignDraftRequestObject()
        {
            // Snippet: PromoteCampaignDraft(PromoteCampaignDraftRequest, CallSettings)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = CampaignDraftServiceClient.Create();
            // Initialize request argument(s)
            PromoteCampaignDraftRequest request = new PromoteCampaignDraftRequest { CampaignDraft = "", };
            // Make the request
            Operation<Empty, Empty> response = campaignDraftServiceClient.PromoteCampaignDraft(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Empty> retrievedResponse = campaignDraftServiceClient.PollOncePromoteCampaignDraft(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PromoteCampaignDraftAsync</summary>
        public async Task PromoteCampaignDraftRequestObjectAsync()
        {
            // Snippet: PromoteCampaignDraftAsync(PromoteCampaignDraftRequest, CallSettings)
            // Additional: PromoteCampaignDraftAsync(PromoteCampaignDraftRequest, CancellationToken)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = await CampaignDraftServiceClient.CreateAsync();
            // Initialize request argument(s)
            PromoteCampaignDraftRequest request = new PromoteCampaignDraftRequest { CampaignDraft = "", };
            // Make the request
            Operation<Empty, Empty> response = await campaignDraftServiceClient.PromoteCampaignDraftAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Empty> retrievedResponse = await campaignDraftServiceClient.PollOncePromoteCampaignDraftAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PromoteCampaignDraft</summary>
        public void PromoteCampaignDraft()
        {
            // Snippet: PromoteCampaignDraft(string, CallSettings)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = CampaignDraftServiceClient.Create();
            // Initialize request argument(s)
            string campaignDraft = "";
            // Make the request
            Operation<Empty, Empty> response = campaignDraftServiceClient.PromoteCampaignDraft(campaignDraft);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Empty> retrievedResponse = campaignDraftServiceClient.PollOncePromoteCampaignDraft(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PromoteCampaignDraftAsync</summary>
        public async Task PromoteCampaignDraftAsync()
        {
            // Snippet: PromoteCampaignDraftAsync(string, CallSettings)
            // Additional: PromoteCampaignDraftAsync(string, CancellationToken)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = await CampaignDraftServiceClient.CreateAsync();
            // Initialize request argument(s)
            string campaignDraft = "";
            // Make the request
            Operation<Empty, Empty> response = await campaignDraftServiceClient.PromoteCampaignDraftAsync(campaignDraft);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Empty> retrievedResponse = await campaignDraftServiceClient.PollOncePromoteCampaignDraftAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListCampaignDraftAsyncErrors</summary>
        public void ListCampaignDraftAsyncErrorsRequestObject()
        {
            // Snippet: ListCampaignDraftAsyncErrors(ListCampaignDraftAsyncErrorsRequest, CallSettings)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = CampaignDraftServiceClient.Create();
            // Initialize request argument(s)
            ListCampaignDraftAsyncErrorsRequest request = new ListCampaignDraftAsyncErrorsRequest
            {
                ResourceNameAsCampaignDraftName = CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
            };
            // Make the request
            PagedEnumerable<ListCampaignDraftAsyncErrorsResponse, Status> response = campaignDraftServiceClient.ListCampaignDraftAsyncErrors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Status item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCampaignDraftAsyncErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Status> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCampaignDraftAsyncErrorsAsync</summary>
        public async Task ListCampaignDraftAsyncErrorsRequestObjectAsync()
        {
            // Snippet: ListCampaignDraftAsyncErrorsAsync(ListCampaignDraftAsyncErrorsRequest, CallSettings)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = await CampaignDraftServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCampaignDraftAsyncErrorsRequest request = new ListCampaignDraftAsyncErrorsRequest
            {
                ResourceNameAsCampaignDraftName = CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCampaignDraftAsyncErrorsResponse, Status> response = campaignDraftServiceClient.ListCampaignDraftAsyncErrorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Status item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCampaignDraftAsyncErrorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Status> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCampaignDraftAsyncErrors</summary>
        public void ListCampaignDraftAsyncErrors()
        {
            // Snippet: ListCampaignDraftAsyncErrors(string, string, int?, CallSettings)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = CampaignDraftServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaignDrafts/[CAMPAIGN_DRAFT]";
            // Make the request
            PagedEnumerable<ListCampaignDraftAsyncErrorsResponse, Status> response = campaignDraftServiceClient.ListCampaignDraftAsyncErrors(resourceName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Status item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCampaignDraftAsyncErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Status> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCampaignDraftAsyncErrorsAsync</summary>
        public async Task ListCampaignDraftAsyncErrorsAsync()
        {
            // Snippet: ListCampaignDraftAsyncErrorsAsync(string, string, int?, CallSettings)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = await CampaignDraftServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaignDrafts/[CAMPAIGN_DRAFT]";
            // Make the request
            PagedAsyncEnumerable<ListCampaignDraftAsyncErrorsResponse, Status> response = campaignDraftServiceClient.ListCampaignDraftAsyncErrorsAsync(resourceName);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Status item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCampaignDraftAsyncErrorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Status> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCampaignDraftAsyncErrors</summary>
        public void ListCampaignDraftAsyncErrorsResourceNames()
        {
            // Snippet: ListCampaignDraftAsyncErrors(CampaignDraftName, string, int?, CallSettings)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = CampaignDraftServiceClient.Create();
            // Initialize request argument(s)
            CampaignDraftName resourceName = CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]");
            // Make the request
            PagedEnumerable<ListCampaignDraftAsyncErrorsResponse, Status> response = campaignDraftServiceClient.ListCampaignDraftAsyncErrors(resourceName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Status item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCampaignDraftAsyncErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Status> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCampaignDraftAsyncErrorsAsync</summary>
        public async Task ListCampaignDraftAsyncErrorsResourceNamesAsync()
        {
            // Snippet: ListCampaignDraftAsyncErrorsAsync(CampaignDraftName, string, int?, CallSettings)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = await CampaignDraftServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignDraftName resourceName = CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]");
            // Make the request
            PagedAsyncEnumerable<ListCampaignDraftAsyncErrorsResponse, Status> response = campaignDraftServiceClient.ListCampaignDraftAsyncErrorsAsync(resourceName);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Status item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCampaignDraftAsyncErrorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Status> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Status item in singlePage)
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
